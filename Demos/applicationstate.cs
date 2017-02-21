protected void Session_Start(object sender, EventArgs e)  
{  
   //when session in start application variable is increased by 1  
   Application.Lock();  
   Application["user"] = (int) Application["user"]+1;  
   Application.UnLock();  
}  