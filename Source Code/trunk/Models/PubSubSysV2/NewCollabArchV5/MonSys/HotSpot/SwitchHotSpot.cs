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
using Simulation;
using Simulation.MonSysContext;

namespace Simulation.MonSysContext.HotSpotContext
{

    public class SwitchHotSpot : DP_Method, DP_IMethod
    {
        public HotSpot HotSpot;

        public override void Initialize()
        {
          base.Initialize();


        }

        public override void Run()
        {
HotSpot.CurrHotSpotId++;
HotSpot.Undetected = HotSpot.UndetectedDict.Count;
double timeNow = Model.Simulation.Simulator.Scheduler.Time;
String hsUn = "";
foreach (int hsid in HotSpot.UndetectedDict.Keys)
{
	hsUn = hsUn+", "+hsid;
}
DomainProAnalyst.Instance.Report("Undetected Situations: "+hsUn+" @:"+timeNow);
HotSpot.UndetectedDict.Add(HotSpot.CurrHotSpotId,timeNow);
HotSpot.LastDuration = timeNow - HotSpot.SwitchMoment;
HotSpot.SwitchMoment = timeNow;

// reset all sensors
foreach(Topic topic in HotSpot.MonSys.TopicGroupList[0].Topics)
{
	topic.IsPartOfHotspot = false;
}
// set new hotspot sensor set
// select nr of groups
int topicCount = HotSpot.MonSys.TopicGroupList[0].Topics.Count-15;
if (topicCount == 0)
	return;
double alpha = 1;
double beta = 3;
int sel = (int)Math.Floor(Math.Max(1, Random.Beta(alpha, beta)*topicCount)+8);
DomainProAnalyst.Instance.Report("Hotspot Switching Situation "+HotSpot.CurrHotSpotId+" with burst sensor topics: "+sel);
// select groups
HotSpot.EventBurstSourceCount = sel;
while (sel > 0 && topicCount > 0) {
   if( Random.Uniform() < sel / topicCount ) {
	// set to burst mode
	HotSpot.MonSys.TopicGroupList[0].Topics[topicCount-1].IsPartOfHotspot = true;
      sel--;
   }
   topicCount--;
}
        }

        public override double Duration
        {
          get
          {
return 0;
          }
        }

    }
}
