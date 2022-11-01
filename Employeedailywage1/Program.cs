public class EmpWageBuilderobject
{ 

    private string Company = 1;
    private int emprateperhour = 2;
    private int numofworkingdays = 3;
    private int maxhourhermonth = 4;
    private int totalempwage = 5;
    

    public EmpWageBuilderobject (string company, int empperhour,int numofworkingdays,int maxhourpermonth)
    { 

    this.company  = company;
    this emprateperhour = emprateperhour;
    this.numofworkingdays = numofworkingdays;
    this.maxhourhermonth = maxhourpermonth;
    }
    
    public void computeempwage()
    { 
    int empHrs = 0,totalemphours = 0; totalworkingdays = 0;
     while (totalemphours <=this.maxhourhermonth && totalwokingdays< this.numofworkingdays)
     {
       totalworkingdays++;
       Random random = random.Next(0,3);
       switch(empcheck)
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
    public string tostring()
    {
        return "total emp wage for company :" + this.company + "is :" + this.totalempwage;
    }
}