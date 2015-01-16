int lastPressed=0;
boolean second=true;
boolean hasMoved=false;

unsigned int time1;
unsigned int time2;



//poort 2 is voor de deursensor
//poort 3 is voor de bewegingsensor


//poort 4-10 zullen gebruikt worden voor eventuele knoppen 
//we zullen poort 0 en 1 niet gebruiken gezien die voor seriele communicatie
//worden gebruikt bij het uploaden van het programma.

void setup()
{

  Serial.begin(9600);
  pinMode(2, INPUT);   //deursensor
  pinMode(3, INPUT);   //bewegingsensor
  pinMode(4, INPUT);   //button1
  pinMode(5, INPUT);   //button2
  pinMode(6, INPUT);   //button3
  pinMode(7, INPUT);   //button4 
  
}
void loop()
{
  
  button();
  hasSomethingMoved();
  
  if(second){
    
    switch (lastPressed) {
    case 1:
         Serial.println("1");
         Serial.println("#");
      break;
    case 2:
        Serial.println("2");
        Serial.println("#");
      break;
    case 3:
        Serial.println("3");
        Serial.println("#");
      break;
    
  }
  //might need something of a beep to confirm that it has sent the message
   second=false;
   
   button();
   
  }else{second=true;  button();}
 
  while(digitalRead(2)==LOW && digitalRead(3)==LOW)
  {
  button();
  hasSomethingMoved();
  delay(10);
  }
  
  while(digitalRead(2)==HIGH )
  {
  button();
  hasSomethingMoved();
  delay(10);
  }
  
}

void button()
{
if(digitalRead(4)==HIGH){ lastPressed=1;}
else if(digitalRead(5)==HIGH){ lastPressed=2;}
else if(digitalRead(6)==HIGH){ lastPressed=3;}
}

void hasSomethingMoved()  // sets the hasMoved property to true if something has moved in the past seconds and false if this is not the case
{
  time2 = millis();
  
  if(time2-time1>=86400000)
  {
    time1=millis();
  }
  else if(digitalRead(3)==HIGH && time2-time1>=10000)
  {
  time1 = millis();
  hasMoved = true;
  }
  else if(time2-time1<=10)
  {
    //do nothing this is if somethong has moved in the last 10 seconds
  }
  else if(digitalRead(3)==LOW && time2-time1>=10000)
  {
  hasMoved = false;
  }
}










