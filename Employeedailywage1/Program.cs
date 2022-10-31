class Program

{ 

    public const int IS_PART_TIME = 1;
    public const int IS_FULL_TIME = 2;
    

    public static int computeEmpWage(string company,int empperhour,int numofworkingdays,int maxhourpermonth)
    { 

    int empHrs = 0;
    int totalEmphrs = 0;
    int totalworkingdays =0 ;
    while (totalEmphrs < = MAX_HRS_IN_MONTH && totalworkingdays < NUM_OF_WORKING_DAYS)
    { 
    totalworkingdays++;
    Random random = new Random();
    switch (empCheck)
    {
        case IS_PART_TIME;
        empHrs = 4;
        break;
        case Is_Full_Time;
        empHrs = 8;
        break;
        default:
         empHrs = 0;
         break;
    }
    totalEmphrs += empHrs;
    Console.WriteLine("Day#:" + totalworkingdays + "emp hrs :" + empHrs);
    }
    int totalEmpWage = totalEmphrs * EMP_RATE_HER_HOUR;
    Console.WriteLine("Total Emp Wage for company : " + company + "is : " + totalEmpWage);
        return totalEmpWage;
 }
    static void Main(string[] args)
    {
        computeEmpWage("Dmart",20,2,10);
        computeEmpWage("reliance",10,15,8)
    }
}