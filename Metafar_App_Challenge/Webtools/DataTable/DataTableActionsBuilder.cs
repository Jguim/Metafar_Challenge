namespace WebApp.WebTools.DataTable
{
    public class DataTableActionsBuilder
    {
        private readonly List<DataTableAction> actions;

        public DataTableActionsBuilder(params DataTableAction[] actions)
        {
            this.actions = actions?.ToList() ?? new List<DataTableAction>();
        }

        public DataTableActionsBuilder AddAction(DataTableAction action)
        {
            actions.Add(action);

            return this;
        }

        public List<DataTableAction> Build() => actions.ToList();
    }
}
