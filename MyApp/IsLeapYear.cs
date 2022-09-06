namespace MyApp;

public class IsLeapYear {
    

    public Boolean Is_Leap_Year(int year) {
        if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0) && year >= 1582) {
            return true; 
        }
        else {
            return false;
        }
    }
}
