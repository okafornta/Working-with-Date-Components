// TASK: Writing a program that display various components of the DateTime object.
// Current date and time (using single statement)

DateTime now = DateTime.Now;

// Picking up individual components
int day = now.Day;
int month = now.Month;
int year = now.Year;
int hour = now.Hour;
int minute = now.Minute;
int second = now.Second;
DateTime justDateWithOutTime = now.Date;

//Output
Console.WriteLine("Day: " + day);
Console.WriteLine("Month: " + month);
Console.WriteLine("Year: " + year);
Console.WriteLine("Hour: " + hour);
Console.WriteLine("Minute: " + minute); 
Console.WriteLine("Seconds:" + second);
Console.WriteLine("Date component: " + justDateWithOutTime);

// Formating output our own way
Console.WriteLine("Current date: " + year + "/" + month +"/" + day +
  "." + hour +  " hours " + minute + " minutes " + second + 
  " seconds. ");

// Waiting for Enter
Console.ReadLine();