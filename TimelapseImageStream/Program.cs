// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the timelapse image grabber");

var fullDirectoryString = @"C:\Users\Access Account\Videos\Timelapses\" + "Octopus";

Directory.CreateDirectory(@"C:\Users\Access Account\Videos\Timelapses");
Directory.CreateDirectory(fullDirectoryString);

int currentIndex = 0;
var fmnt = "00000";
var timer = new PeriodicTimer(TimeSpan.FromMinutes(1));
var wc = new System.Net.WebClient();

while (await timer.WaitForNextTickAsync())
{
    wc.DownloadFile(@"http://192.168.1.246:8080/?action=snapshot", fullDirectoryString + @"\Timelapse " + currentIndex.ToString(fmnt) + ".png");
    Console.WriteLine(DateTime.Now.ToString("G") + ": File downloaded");
    currentIndex++;
}