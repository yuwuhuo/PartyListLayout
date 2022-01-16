﻿using System;
using System.Runtime.InteropServices;

namespace PartyListLayout.GameStructs.NumberArray {
    [StructLayout(LayoutKind.Sequential, Size = 710 * 4)]
    public unsafe struct AddonPartyListIntArray {
        /* 000 */ public int Unknown000;
        /* 001 */ public int Unknown001;
        
        /* 002 */ public int PartyLeaderIndex;
        
        /* 003 */ public int Unknown003;
        /* 004 */ public int Unknown004;
        /* 005 */ public int PartyMemberCount;
        /* 006 */ public int Unknown006;
        /* 007 */ public int Unknown007;
        /* 008 */ public int Unknown008;

        /* 009 */ public AddonPartyListMembersIntArray PartyMember;
    }

    [StructLayout(LayoutKind.Sequential, Size = 39 * 4 * 8)]
    public unsafe struct AddonPartyListMembersIntArray {
        public AddonPartyListMemberIntArray Member0;
        public AddonPartyListMemberIntArray Member1;
        public AddonPartyListMemberIntArray Member2;
        public AddonPartyListMemberIntArray Member3;
        public AddonPartyListMemberIntArray Member4;
        public AddonPartyListMemberIntArray Member5;
        public AddonPartyListMemberIntArray Member6;
        public AddonPartyListMemberIntArray Member7;

        public AddonPartyListMemberIntArray this[int i] {
            get {
                return i switch {
                    0 => Member0,
                    1 => Member1,
                    2 => Member2,
                    3 => Member3,
                    4 => Member4,
                    5 => Member5,
                    6 => Member6,
                    7 => Member7,
                    _ => throw new IndexOutOfRangeException("Index should be between 0 and 7")
                };
            }
            set {
                switch (i) {
                    case 0: Member0 = value; break;
                    case 1: Member1 = value; break;
                    case 2: Member2 = value; break;
                    case 3: Member3 = value; break;
                    case 4: Member4 = value; break;
                    case 5: Member5 = value; break;
                    case 6: Member6 = value; break;
                    case 7: Member7 = value; break;
                    default: throw new IndexOutOfRangeException("Index should be between 0 and 7");
                }
            }
        }
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 39 * 4)]
    public unsafe struct AddonPartyListMemberIntArray {
        public int Level;
        public int ClassJobIcon;

        public int Unknown2;
            
        public int HP;
        public int HPMax;
        public int ShieldPercentage;
        public int MP;
        public int MPMax;

        public int Unknown8;
        public int Unknown9;
        
        public int PartySlot;

        public int Unknown11;
        public int Unknown12;
        
        public int StatusEffectCount;
        public AddonPartyListMemberStatusEffectsIntArray StatusEffect;

        public int Unknown24;
        public int Unknown25;
        public int Unknown26;
        public int Unknown27;
        public int Unknown28;
        public int Unknown29;
        public int Unknown30;
        public int Unknown31;
        public int Unknown32;
        public int Unknown33;
        
        public int CastingPercent;
        public int ObjectID;
    }

    [StructLayout(LayoutKind.Sequential, Size = 4 * 10)]
    public struct AddonPartyListMemberStatusEffectsIntArray {
        public int Status0;
        public int Status1;
        public int Status2;
        public int Status3;
        public int Status4;
        public int Status5;
        public int Status6;
        public int Status7;
        public int Status8;
        public int Status9;

        public int this[int i] {
            get {
                return i switch {
                    0 => Status0,
                    1 => Status1,
                    2 => Status2,
                    3 => Status3,
                    4 => Status4,
                    5 => Status5,
                    6 => Status6,
                    7 => Status7,
                    8 => Status8,
                    9 => Status9,
                    _ => throw new IndexOutOfRangeException("Index should be between 0 and 9")
                };
            }
            set {
                switch (i) {
                    case 0: Status0 = value; break;
                    case 1: Status1 = value; break;
                    case 2: Status2 = value; break;
                    case 3: Status3 = value; break;
                    case 4: Status4 = value; break;
                    case 5: Status5 = value; break;
                    case 6: Status6 = value; break;
                    case 7: Status7 = value; break;
                    case 8: Status8 = value; break;
                    case 9: Status9 = value; break;
                    default: throw new IndexOutOfRangeException("Index should be between 0 and 9");
                }
            }
        }



    }

}
