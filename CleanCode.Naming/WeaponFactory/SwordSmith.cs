﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SwordSmith.cs" company="bbv Software Services AG">
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
//   Defines the SwordSmith type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CleanCode.Naming.WeaponFactory
{
    using CleanCode.Naming.Weapon;
    using CleanCode.Naming.Weapons;

    /// <summary>
    /// The sword smith
    /// </summary>
    public class SwordSmith : IWeaponFactory
    {
        /// <summary>
        /// Forges the new weapon.
        /// </summary>
        /// <returns></returns>
        public Weapon ForgeNewWeapon()
        {
            return new SwordImpl();
        }
    }
}