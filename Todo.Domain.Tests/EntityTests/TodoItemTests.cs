using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Entities;

namespace Todo.Domain.Tests.EntityTests
{
    [TestClass]
    public class TodoItemTests
    {
         private readonly TodoItem _todoItem = new TodoItem("Título da tarefa", "Pedro Ivo", DateTime.Now);
        [TestMethod]
        public void Dado_um_novo_todo_o_mesmo_nao_pode_ser_concluido()
        {
            Assert.AreEqual(_todoItem.Done, false);
        }
    }
}