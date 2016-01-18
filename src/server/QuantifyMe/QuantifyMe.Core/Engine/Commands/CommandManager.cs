using System;

namespace QuantifyMe.Core.Engine.Commands
{
    public class CommandManager
    {
        private static readonly object[] emptyObjectArray = new object[0];

        public TCommand Create<TCommand>() where TCommand : ICommand
        {
            var commandType = typeof (TCommand);
            var constructor = commandType.GetConstructor(Type.EmptyTypes);
            var command = (TCommand) constructor.Invoke(emptyObjectArray);

            return command;
        }
    }
}