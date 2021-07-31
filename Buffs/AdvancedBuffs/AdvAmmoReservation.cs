﻿using Microsoft.Xna.Framework;
    public class AdvAmmoReservation : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Advanced Ammo Reservation");
            Description.SetDefault("30% chance to not consume ammo");
        }

        public override void Update(Player player, ref int k)
        {
            player.ammoPotion = true;
        }
    }