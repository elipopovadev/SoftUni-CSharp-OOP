﻿using System;

namespace MilitaryElite
{
    public class Mission : IMission
    {
        private string state;
        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }

        public string CodeName { get; }
        public string State
        {
            get => state;
            private set
            {
                if (value != "inProgress" && value != "Finished")
                {
                    throw new ArgumentException();
                }

                this.state = value;
            }
        }

        public void CompleteMission()
        {
            if(this.State == "inProgress")
            {
                this.State = "Finished";
            }         
        }

        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.State}";
        }
    }
}
