using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using DomainPro.Core.Types;
using DomainPro.Analyst;
using DomainPro.Analyst.Interfaces;
using DomainPro.Analyst.Types;
using DomainPro.Analyst.Objects;
using DomainPro.Analyst.Engine;
using Analyst.Types;

namespace Simulation
{
    using FacilityContext;

    public class Facility : DP_Component, DP_IComponent
    {
        private List<ProcedureRooms> ProcedureRoomsInstances = new List<ProcedureRooms>();

        public List<ProcedureRooms> ProcedureRoomsList
        {
          get
          {
            return ProcedureRoomsInstances;
          }
          set
          {
            ProcedureRoomsInstances = value;
          }
        }

        private List<WaitingRoom> WaitingRoomInstances = new List<WaitingRoom>();

        public List<WaitingRoom> WaitingRoomList
        {
          get
          {
            return WaitingRoomInstances;
          }
          set
          {
            WaitingRoomInstances = value;
          }
        }

        private List<PrepRoom> PrepRoomInstances = new List<PrepRoom>();

        public List<PrepRoom> PrepRoomList
        {
          get
          {
            return PrepRoomInstances;
          }
          set
          {
            PrepRoomInstances = value;
          }
        }

        private List<NewNurses> NewNursesInstances = new List<NewNurses>();

        public List<NewNurses> NewNursesList
        {
          get
          {
            return NewNursesInstances;
          }
          set
          {
            NewNursesInstances = value;
          }
        }

        private List<RegistrationRoom> RegistrationRoomInstances = new List<RegistrationRoom>();

        public List<RegistrationRoom> RegistrationRoomList
        {
          get
          {
            return RegistrationRoomInstances;
          }
          set
          {
            RegistrationRoomInstances = value;
          }
        }

        private List<FrontDesk> FrontDeskInstances = new List<FrontDesk>();

        public List<FrontDesk> FrontDeskList
        {
          get
          {
            return FrontDeskInstances;
          }
          set
          {
            FrontDeskInstances = value;
          }
        }

        private List<BreakRoom> BreakRoomInstances = new List<BreakRoom>();

        public List<BreakRoom> BreakRoomList
        {
          get
          {
            return BreakRoomInstances;
          }
          set
          {
            BreakRoomInstances = value;
          }
        }

        private List<RecoveryRoom> RecoveryRoomInstances = new List<RecoveryRoom>();

        public List<RecoveryRoom> RecoveryRoomList
        {
          get
          {
            return RecoveryRoomInstances;
          }
          set
          {
            RecoveryRoomInstances = value;
          }
        }

        private List<DecontaminationRoom> DecontaminationRoomInstances = new List<DecontaminationRoom>();

        public List<DecontaminationRoom> DecontaminationRoomList
        {
          get
          {
            return DecontaminationRoomInstances;
          }
          set
          {
            DecontaminationRoomInstances = value;
          }
        }

        private List<WashRoom> WashRoomInstances = new List<WashRoom>();

        public List<WashRoom> WashRoomList
        {
          get
          {
            return WashRoomInstances;
          }
          set
          {
            WashRoomInstances = value;
          }
        }

        private List<CleanRoom> CleanRoomInstances = new List<CleanRoom>();

        public List<CleanRoom> CleanRoomList
        {
          get
          {
            return CleanRoomInstances;
          }
          set
          {
            CleanRoomInstances = value;
          }
        }

        private List<Entrance> EntranceInstances = new List<Entrance>();

        public List<Entrance> EntranceList
        {
          get
          {
            return EntranceInstances;
          }
          set
          {
            EntranceInstances = value;
          }
        }

        private List<NewNurses1> NewNurses1Instances = new List<NewNurses1>();

        public List<NewNurses1> NewNurses1List
        {
          get
          {
            return NewNurses1Instances;
          }
          set
          {
            NewNurses1Instances = value;
          }
        }

        private MyDoctor MyDoctorInstance;
        public MyDoctor MyDoctor
        {
          get
          {
            return MyDoctorInstance;
          }
          set
          {
            MyDoctorInstance = value;
            if (MyDoctorInstance != null && MyDoctorInstance.Object != this)
            {
              MyDoctorInstance.Object = this;
            }
          }
        }

        public override void Initialize()
        {
          base.Initialize();


            Startup();
        }

        public void Startup()
        {
        }

    }
}
