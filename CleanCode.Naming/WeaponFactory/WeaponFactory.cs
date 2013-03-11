﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WeaponFactory.cs" company="bbv Software Services AG">
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
//   Defines the WeaponFactory type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CleanCode.Naming.WeaponFactory
{
    using System;
    using System.Collections.Generic;

    using CleanCode.Naming.Weapon;
    using CleanCode.Naming.Weapons;

    /// <summary>
    /// Creates new weapons for the ultimate fight.
    /// </summary>
    public class WeaponFactory
    {
        /// <summary>
        /// The smith register
        /// </summary>
        private readonly Dictionary<int, IWeaponFactory> smithRegister;

        /// <summary>
        /// The weapon indication
        /// </summary>
        private readonly Random weaponIndication;

        /// <summary>
        /// Prevents a default instance of the <see cref="WeaponFactory"/> class from being created.
        /// </summary>
        private WeaponFactory()
        {
            this.weaponIndication = new Random();
            this.smithRegister = new Dictionary<int, IWeaponFactory>();
        }

        /// <summary>
        /// Forges randomly a new weapon.
        /// </summary>
        public Weapon ForgeNewWeapon()
        {
            int predicatedWeaponCode = this.weaponIndication.Next() % 3;

            return this.smithRegister[predicatedWeaponCode].ForgeNewWeapon();
        }
    }
}