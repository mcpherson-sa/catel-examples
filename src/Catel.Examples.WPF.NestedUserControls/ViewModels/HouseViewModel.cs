// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HouseViewModel.cs" company="Catel development team">
//   Copyright (c) 2008 - 2017 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Examples.NestedUserControls.ViewModels
{
    using Fody;
    using Models;
    using MVVM;

    public class HouseViewModel : ViewModelBase
    {
        #region Constructors
        public HouseViewModel(HouseModel house)
        {
            Argument.IsNotNull("house", house);

            House = house;

            AddRoom = new Command(OnAddRoomExecute, OnAddRoomCanExecute);
        }
        #endregion

        #region Properties
        public override string Title
        {
            get { return House.Name; }
        }

        public Command AddRoom { get; private set; }

        private bool OnAddRoomCanExecute()
        {
            return true;
        }

        private void OnAddRoomExecute()
        {
            // var room = ModelGenerator.GenerateRoom("Shane's Room");
            //House.Rooms.Add(room);
            House.Rooms[0].Name = "Duke's House";
        }

        #region Models
        [Model]
        [Expose("Name")]
        [Expose("Price")]
        [Expose("Rooms")]
        public HouseModel House { get; private set; }
        #endregion
        #endregion
    }
}
