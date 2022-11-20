namespace PropertyProj
{
    public class Customer// class Customer
    { //attributes
        int _CustId; //here The default scope the members of a class is private. so we cannot access these variables in testclasst sec obj 
        bool _Status;       // but we should not keep the variable of a class as public then anyone can get and set the value
        string _Cname;
        double _Balance;
        Cities _City;  //this is Cities enum type which consist list of cities.
        string _State;
        public Customer(int CustId, bool Staus, string Cname, double Balance, Cities City, string State)// method to initializing customer attribute
        {
            _CustId = CustId;
            _Cname = Cname;
            _Balance = Balance; 
            _Status = Staus;
            _City = City;   
            _State = State;
            

        }

        public int Custid
        {
            get { return _CustId; }
            //set { _CustId = value; }
        }
        public bool Status
        {
            get { return _Status; }

            set { _Status = value; }
        }

        public string Cname
        {
            get { return _Cname; }
            set {
                if (_Status == true) // here I put condition, If status is "true" that means the account is active then only perform changes/updation to data
                    _Cname =value;
            }

        }

        public double Balance
        {
            get
            {     
             return _Balance;
              
            }
            set 
            
            { 
                if (_Status == true)
                { 
                    if(value>=500)
                 _Balance = value; 
                } 
            }
        }
        public Cities City
        {
            get { return _City; }
            set { if(Status == true)
                
                _City = value; 
                }
        }
       public string State
        {
            get { return _State; }
            set { if (Status == true)
                    _State = value;
                        
                }
        }

    }
}