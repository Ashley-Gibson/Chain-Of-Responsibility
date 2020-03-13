namespace Chain_of_Responsibility
{
    public class Validation : ChainStep
    {
        private string _passString;
        public override string PassString
        {
            set { _passString = value; }
            get { return _passString; }
        }

        public Validation()
        {
            PassString = "true";
        }
    }
}
