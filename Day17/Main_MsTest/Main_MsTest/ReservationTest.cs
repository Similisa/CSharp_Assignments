using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Main_DLL;


namespace Main_MsTest
{
    [TestClass]
    public class ReservationTest
    {
        [TestMethod]
        public void Cancellation_ByAdmin_ToReturnTrue()
        {
            //Arrange
            var reservation = new ReservationTest();
            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });
            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Cancellation_ByMadeBy_ReturnTrue()
        {
            var user = new User();
            var reservation = new Reservation() {madeBy = user };
            var result = reservation.CanBeCancelledBy(reservation.madeBy);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Cancellation_By_Others_To_Return_False()
        {
            var reservation = new Reservation { madeBy = new User() };
            var result = reservation.CanBeCancelledBy(new User());
            Assert.IsFalse(result);
        }
    }
}
