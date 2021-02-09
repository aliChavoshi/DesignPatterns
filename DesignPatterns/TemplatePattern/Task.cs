namespace DesignPatterns.TemplatePattern
{
    public abstract class Task
    {
        private readonly AuditTrail _auditTrail;

        protected Task()
        {
            _auditTrail = new AuditTrail();
        }
        public void Execute()
        {
            _auditTrail.Record();

            DoExecute();
        }
        protected abstract void DoExecute();
    }
}