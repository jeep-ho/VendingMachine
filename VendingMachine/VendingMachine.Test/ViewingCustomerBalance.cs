﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachine.Domain;
using VendingMachine.Framework;
using VendingMachine.Menus;

namespace VendingMachine.Test
{
    [TestClass]
    public class ViewingCustomerBalance
    {
        [TestMethod]
        public void ShouldPrintCorrectCustomerBalance()
        {
            SodaMachine machine = new SodaMachine(10);
            SodaMachineUi machineUi = new SodaMachineUi(machine);
            machine.DepositCustomerMoney(2.25);
            string result = machineUi.PerformAction(MainMenu.Commands.PrintCustomerBalance.Command).ToString();
            Assert.IsTrue(result.Contains("2.25"), string.Format("Result should contain 2.25, actual result was {0}", result));
        }
    }
}
