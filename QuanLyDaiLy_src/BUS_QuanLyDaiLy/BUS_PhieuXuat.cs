﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyDaiLy;
namespace BUS_QuanLyDaiLy
{
    public class BUS_PhieuXuat
    {
        public static ArrayList Dsphieuxuat(int id)
        {
            ArrayList al = DAL_TGPhieuXuat.DSPhieuXuat(id);
            return al;
        }
    }
}
