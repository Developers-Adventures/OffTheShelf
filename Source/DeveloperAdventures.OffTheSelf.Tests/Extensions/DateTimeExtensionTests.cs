﻿// --------------------------------------------------------------------------------------------------------------------
// <auto-generated> 
//      Marked as auto-generated so StyleCop will ignore BDD style tests
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------


#pragma warning disable 169
// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local

namespace DeveloperAdventures.OffTheSelf.Tests.Extensions
{
    using System;

    using DeveloperAdventures.OffTheShelf.Extensions;

    using NUnit.Framework;

    [TestFixture]
    public class DateTimeExtensionTests
    {
        [Test]
        public void CanGetBeginningOfMonth()
        {
            // Arrange
            var date = DateTime.Now;

            // Act
            var firstDayOfMonth = date.BeginningOfMonth();

            // Assert
            Assert.AreEqual(1, firstDayOfMonth.Day);
        }

        [Test]
        public void CanGetEndOfMonth()
        {
            // Arrange
            var date = new DateTime(2012, 2, 1); // February has 29 days in 2012

            // Act
            var endOfMonth = date.EndOfMonth();

            // Assert
            Assert.AreEqual(29, endOfMonth.Day);
        }

        [Test]
        public void CanGetDateWithMillisecondsAtZero()
        {
            // Arrange
            var date = DateTime.Now;

            // Act
            var withNoMilliseconds = date.NoMilliSeconds();

            // Assert
            Assert.AreEqual(0, withNoMilliseconds.Millisecond);
        }

        [Test]
        public void CanGetPeriodsInBetween()
        {
            // Arrange
            var date1 = DateTime.Now;
            var date2 = date1.AddMonths(5);

            // Act
            var periods = date1.PeriodsBetween(date2);
            // Assert
            Assert.AreEqual(5, periods);
        }
    }
}