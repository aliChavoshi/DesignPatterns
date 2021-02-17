namespace DesignPatterns.TemplatePattern
{
    public abstract class Task
    {
        private readonly AuditTrail _auditTrail;

        protected Task()
        {
            _auditTrail = new AuditTrail();
        }
        public void Execute(string message)
        {
            _auditTrail.Record(message);

            DoExecute();
        }
        protected abstract void DoExecute();
    }
}