using System;
using System.Collections;
using System.Collections.Generic;
using DomainPro.Analyst;
using DomainPro.Analyst.Interfaces;
using DomainPro.Analyst.Types;
using DomainPro.Analyst.Objects;
using Analyst.Types;

namespace Simulation
{
    using FacilityContext;
    using PhysicianContext;
    using PatientContext;

    public class SFGHModel : DP_Model, DP_IModel
    {
        private List<Facility> FacilityInstances = new List<Facility>();

        public List<Facility> FacilityList
        {
          get
          {
            return FacilityInstances;
          }
          set
          {
            FacilityInstances = value;
          }
        }

        private List<Physician> PhysicianInstances = new List<Physician>();

        public List<Physician> PhysicianList
        {
          get
          {
            return PhysicianInstances;
          }
          set
          {
            PhysicianInstances = value;
          }
        }

        private List<Patient> PatientInstances = new List<Patient>();

        public List<Patient> PatientList
        {
          get
          {
            return PatientInstances;
          }
          set
          {
            PatientInstances = value;
          }
        }

        private List<MyDoctor> MyDoctorInstances = new List<MyDoctor>();

        public List<MyDoctor> MyDoctorList
        {
          get
          {
            return MyDoctorInstances;
          }
          set
          {
            MyDoctorInstances = value;
          }
        }

        private List<NewChargeNurses> NewChargeNursesInstances = new List<NewChargeNurses>();

        public List<NewChargeNurses> NewChargeNursesList
        {
          get
          {
            return NewChargeNursesInstances;
          }
          set
          {
            NewChargeNursesInstances = value;
          }
        }

        private List<NewNursePractitioners> NewNursePractitionersInstances = new List<NewNursePractitioners>();

        public List<NewNursePractitioners> NewNursePractitionersList
        {
          get
          {
            return NewNursePractitionersInstances;
          }
          set
          {
            NewNursePractitionersInstances = value;
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

        public void Initialize()
        {


        }

    }
}
