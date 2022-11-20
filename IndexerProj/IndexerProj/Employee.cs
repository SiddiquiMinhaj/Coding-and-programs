namespace IndexerProj
{
    internal class Employee
    {
        int Eno;
        String EName, Job, Dname, Location;
        Double Salary;

        public Employee(int Eno, string EName, string Job, string Dname, string Location, double Salary)
        {
            //Eno = eno;
            //EName = eName;
            //Job = job;
            //Dname = dname;
            //Location = location;
            //Salary = salary;

            this.Eno = Eno;
            this.EName = EName;
            this.Job =Job; 
            this.Dname = Dname; 
            this.Location = Location;
            this.Salary = Salary;

        }

        public object this[int Index]                  //why Object: because it can return any type of the value, why this: is to tell we're defining the indexers to current class 
        {
            get { if (Index == 0)
                    return Eno;
                else if (Index == 1)
                    return EName;
                else if (Index == 2)
                    return Job;
                else if (Index == 3)   
                    return Dname;
            else if (Index == 4)
                    return Location;
            else if (Index == 5)
                    return Salary;
                return null;
             }

            set
            {
                if (Index == 0)
                    Eno = (int)value; // value is implicit variable that provides access to the value assigned by user
                else if (Index == 1)  // the data type of this Value is same like your indexer, the data type of our indexer is Object
                    EName = (String)value; // here we're unboxing,  reference type we're converting into value type.
                else if (Index == 2)
                    Job = (String)value;
                else if (Index == 3)
                    Dname = (string)value;
                else if (Index == 4)
                    Location = (string)value;
                else if (Index == 5)
                    Salary = (double)value;
             }
        }
    }
}