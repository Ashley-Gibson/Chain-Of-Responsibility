namespace Chain_of_Responsibility
{
    public class Authentication : ChainStep
    {
        private string _passString;
        public override string PassString 
        {
            set { _passString = value; }
            get { return _passString; }
        }

        public Authentication()
        {
            PassString = "true";
        }
    }
}
