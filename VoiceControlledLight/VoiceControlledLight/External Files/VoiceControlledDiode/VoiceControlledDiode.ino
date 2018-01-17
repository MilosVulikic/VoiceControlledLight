void setup() 
{
  Serial.begin(9600);
  pinMode(13,OUTPUT);
 
}

void loop() 
{
    char id = Serial.read();  
  if(id=='O')
  {
    digitalWrite(13,HIGH);
  }
  if(id=='X')
  {
   digitalWrite(13,LOW);     
  }
}
