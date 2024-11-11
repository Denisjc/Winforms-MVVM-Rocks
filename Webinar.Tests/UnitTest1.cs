using DevExpress.Mvvm;
using System;
using System.Linq;
using Webinar.ViewModels;
using Xunit;

namespace Webinar.Tests
{
    public class UnitTest1
    {

        const string INITIAL_TRACKNAME = "My Test Track";
        const string MODIFIED_TRACKNAME = "My Modified Test Track";
        const string RESET_TRACKNAME = "";


        public UnitTest1()
        {
            
        }

        [Fact]
        public void TestResetNameCommandNo()
        {
            //Arrange
            var expected = INITIAL_TRACKNAME;

            var vm = TrackViewModel.Create(new TrackInfo() { Name = expected });
            var serviceContainer = (vm as ISupportServices).ServiceContainer;

            IMessageBoxService msgSvc = new DummyServiceForMessageBox(MessageResult.No);
            serviceContainer.RegisterService(msgSvc);

            //Act
            //Testing the ResetName behaviour while clicking No on the confirmation dialog...
            vm.ResetName();

            //Assert
            var actual = vm.Name;
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void TestResetNameCommandYes() 
        {

            //Arrange
            var expected = RESET_TRACKNAME;

            var vm = TrackViewModel.Create(new TrackInfo() { Name = expected });
            var serviceContainer = (vm as ISupportServices).ServiceContainer;

            IMessageBoxService msgSvc = new DummyServiceForMessageBox(MessageResult.Yes);
            serviceContainer.RegisterService(msgSvc);

            //Act 
            //Testing the ResetName command while clicking Yes on the confirmation dialog...
            vm.ResetName();

            //Assert
            var actual = vm.Name;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSaveCommand()
        {
            //Arrange
            var expected = INITIAL_TRACKNAME;

            var vm = TrackViewModel.Create(new TrackInfo() { Name = expected });
            vm.Name = MODIFIED_TRACKNAME;

            //Act
            //Testing the Save command...
            vm.Save();

            //Assert
            var actual = vm.Name;
            Assert.Equal(MODIFIED_TRACKNAME, vm.Name);
        }

        [Fact]
        public void TestCancelCommand()
        {
        }
    }
}
