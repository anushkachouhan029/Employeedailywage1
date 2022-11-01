public class EmpWageBuilderobject
{ 
    public const int IS_PART_TIME = 1;
    public const int IS_PART_DATE = 2;

    private int numofcompany = 0;
    private CompanyEmpWage[] companyEmpWages;
   
    public EmpWageBuilderArray()
    {
        this.companyEmpWagesArray = new CompanyEmpWage[5];
    }

    public void addCompany(string company,int emprateperhour,int numofworkingdays, int maxhourpermonth)
    {
        companyEmpWages[this.numofcompany] = new CompanyEmpWage(company,emprateperhour,numofworkingdays,maxhourpermonth);
        numofcompany++;
    }
    
    public void companyempwage()
    {
        for(int i = 0; i < numofcompany; i++)
        {
            companyempwageArray[i].setTotalEmpwage(this.computeempwage(this.computeempwa[i]));
            Console.WriteLin(this.companyempwag[i].tostring());
       }
    }
    

    private int computeempwage(companyempwage companyempwage)
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
    {
        return "total emp wage for company :" + this.company + "is :" + this.totalempwage;
    }
}