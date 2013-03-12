﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AncientGreek.cs" company="bbv Software Services AG">
//   Copyright (c) 2013
//   
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//   
//   http://www.apache.org/licenses/LICENSE-2.0
//   
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
// <summary>
//   Defines the AncientGreek type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CleanCode.Naming.Warriors
{
    using CleanCode.Naming.Weapons;

    /// <summary>
    /// The mighty and super clever with the spear ancient greek from the time of Alexander the Great!!!!
    /// </summary>
    /// <remarks>
    /// The clever ancient greek is a master of the art of the spear. However, if he doesn't get his
    /// favored killing tool, he will fight with his bare hands rather than using another weapon!
    /// </remarks>
    public class AncientGreek
    {
        /// <summary>
        /// The clever ancient greek weapon.
        /// </summary>
        private Weapon cleverAncientGreekWeapon;

        /// <summary>
        /// Takes the killing tool.
        /// </summary>
        /// <param name="weapon">The weapon.</param>
        public void TakeKillingTool(Weapon weapon)
        {
            if (weapon is SpearImpl)
            {
                this.cleverAncientGreekWeapon = weapon;
            }
        }
    }
}