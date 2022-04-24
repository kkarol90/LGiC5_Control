using DriveControlLibrary;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveControlTests
{
    public class ModbusMemoryTests
    {
        [Test]
        public void GroupedRegistersToDataExchange_RegisterInGroup8()
        {
            //arrange
            List<List<Register>> regToDataEx = new List<List<Register>>();
            List<Register> registers = new List<Register>();
            for (ushort i = 0; i < 26; i++)
            {
                registers.Add(new Register(i));
            }
            //act
            regToDataEx = ModbusMemory.GroupedRegistersToDataExchange(registers, 8);
            //assert
            Assert.That(regToDataEx.Count, Is.EqualTo(4));
            Assert.That(regToDataEx[0].Count, Is.EqualTo(8));
            Assert.That(regToDataEx[1].Count, Is.EqualTo(8));
            Assert.That(regToDataEx[2].Count, Is.EqualTo(8));
            Assert.That(regToDataEx[3].Count, Is.EqualTo(2));
        }

        [Test]
        public void GroupedRegistersToDataExchange_RegisterInGroup16()
        {
            //arrange
            List<List<Register>> regToDataEx = new List<List<Register>>();
            List<Register> registers = new List<Register>();
            for (ushort i = 1; i <= 36; i++)
            {
                registers.Add(new Register(i));
            }
            //act
            regToDataEx = ModbusMemory.GroupedRegistersToDataExchange(registers, 16);
            //assert
            Assert.That(regToDataEx.Count, Is.EqualTo(3));
            Assert.That(regToDataEx[0].Count, Is.EqualTo(16));
            Assert.That(regToDataEx[1].Count, Is.EqualTo(16));
            Assert.That(regToDataEx[2].Count, Is.EqualTo(4));
        }

        [Test]
        public void GroupedRegistersToDataExchange_NotInOrder()
        {
            //arrange
            List<List<Register>> regToDataEx = new List<List<Register>>();
            List<Register> registers = new List<Register>();
            for (ushort i = 0; i < 3; i++)
            {
                for (ushort j = 1; j <= 6; j++)
                {
                    registers.Add(new Register((ushort)(i * 10 + j)));
                }
            }
            //act
            regToDataEx = ModbusMemory.GroupedRegistersToDataExchange(registers, 8);
            //assert
            Assert.That(regToDataEx.Count, Is.EqualTo(3));
            Assert.That(regToDataEx[0].Count, Is.EqualTo(6));
            Assert.That(regToDataEx[1].Count, Is.EqualTo(6));
            Assert.That(regToDataEx[2].Count, Is.EqualTo(6));
        }
    }
}
