namespace ConsoleForum.Commands
{
    using ConsoleForum.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LogoutCommand : AbstractCommand, IExecutable
    {
        public LogoutCommand(IForum forum)
            : base(forum)
        {
        }

        public override void Execute()
        {
            this.ValidateLoggedUser();

            this.Forum.CurrentUser = null;
            this.Forum.CurrentQuestion = null;
            this.Forum.Output.AppendLine(Messages.LogoutSuccess);
        }
    }
}
