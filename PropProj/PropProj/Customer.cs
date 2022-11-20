namespace PropProj
{
    public class Customer
    {
        int _CustId;
        bool _Status;
        string _Cname;
        double _Balance;
        string _State;
        Cities _City;
        public Customer(int custId, bool status, string cname, double balance, string state, Cities City)
        {
            _CustId = custId;
            _Status = status;
            _Cname = cname;
            _Balance = balance;
            _State = state;
            _City = City;
        }

        public int CustId
        {
            get { return _CustId; }
        }

        public bool Status
        {
            get { return _Status; }

            set {           
                _Status = value;
            }
        }

        public string Cname
        {
            get { return _Cname; }

            set { if(_Status==true)
                _Cname = value; }
        }

        public double Balance
        {
            get { return _Balance; }

            set
            {
                if (Status == true) 
                _Balance = value; }
        }

        public string State
        {
            get { return _State; }
            set
            {
                if (Status == true)
                    _State = value;
            }
        }
        public Cities City
        {
            get { return _City; }
            set { if(Status == true)
                                  
                _City = value; }
        }

    }

  

    
}