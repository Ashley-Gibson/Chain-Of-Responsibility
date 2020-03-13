namespace Chain_of_Responsibility
{
    public class Authorisation : ChainStep
    {
        private string _passString;
        public override string PassString
        {
            set { _passString = value; }
            get { return _passString; }
        }

        public Authorisation()
        {
            PassString = "true";
        }
    }
}
