namespace MyApp;

public class IsLeapYear {
    
    private int year;

    public Boolean Is_Leap_Year(int year) {
        if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0) && year >= 1582) {
            return true; 
        }
        else {
            return false;
        }
    }

    public Boolean IsLeapYearAnswer () {

        int num = Convert.ToInt32(Console.ReadLine()); 

        if (Is_Leap_Year(num)) {
            Console.WriteLine("Yay");
            return true;
        }
        else {
            Console.WriteLine("Nay");
            return false;
        }

    }
}
