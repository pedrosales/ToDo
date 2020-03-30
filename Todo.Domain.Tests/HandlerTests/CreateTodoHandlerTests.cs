using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Commands;
using Todo.Domain.Handlers;
using Todo.Domain.Tests.Repositories;

namespace Todo.Domain.Tests.HandlerTests
{
    [TestClass]
    public class CreateTodoHandlerTests
    {
        private readonly CreateTodoCommand _invalidCommand = new CreateTodoCommand("", "", DateTime.Now);
        private readonly CreateTodoCommand _validCommand = new CreateTodoCommand("Titulo", "Pedro Ivo", DateTime.Now);
        private GenericCommandResult _genericCommandResult = new GenericCommandResult();
        private readonly TodoHandler _handler = new TodoHandler(new FakeTodoRepository());

        [TestMethod]
        public void Dado_um_comando_invalido_deve_interromper_a_execucao()
        {
            _genericCommandResult = (GenericCommandResult)_handler.Handle(_invalidCommand);

            Assert.AreEqual(_genericCommandResult.Success, false);
        }

        [TestMethod]
        public void Dado_um_comando_valido_deve_criar_a_tarefa()
        {
            _genericCommandResult = (GenericCommandResult)_handler.Handle(_validCommand);

            Assert.AreEqual(_genericCommandResult.Success, true);
        }
    }
}
