
void Word(string name, int index)  //аннаf  
{ 
  if(name.Length/2 != index)
  {
    if(name[index] == name[name.Length-index-1])
    {
        Word(name, index+1);
    }
  } else if(index >=2)
  {
    System.Console.WriteLine("палиндром");
  }else
  {
    System.Console.WriteLine(" не палиндром");
  }
  
} 

Word("Сергей", 0);

