﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Developer_Punisher.MissileLauncherService;

namespace Developer_Punisher.BuildService
{
    public partial class BuildingBuild
    {
        public override Build TakeActionFrom(Build previousBuild)
        {
            previousBuild.ReportBuildBuilding();
            return previousBuild;
        }

        public override void ReportBuildFailed()
        {
            this.missileLauncher.Execute(new FireCommand());
        }

        public override void ReportBuildPassed()
        {
        }

        public override void ReportBuildBuilding()
        {
        }
    }
}
