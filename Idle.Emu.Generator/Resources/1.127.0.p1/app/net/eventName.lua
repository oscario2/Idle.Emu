local eventname = {}
eventname.EVENT_CMD_1_1 = "EVENT_CMD_1_1"
eventname.EVENT_CMD_2_1 = "EVENT_CMD_2_1"
eventname.EVENT_CMD_2_2 = "EVENT_CMD_2_2"
eventname.EVENT_CMD_2_3 = "EVENT_CMD_2_3"
eventname.EVENT_CMD_3_1 = "EVENT_CMD_3_1"
eventname.EVENT_CMD_3_2 = "EVENT_CMD_3_2"
eventname.EVENT_CMD_3_18 = "EVENT_CMD_3_18"
eventname.EVENT_CMD_4_1 = "EVENT_CMD_4_1"
eventname.EVENT_CMD_5_0 = "EVENT_CMD_5_0"
eventname.EVENT_CMD_5_1 = "EVENT_CMD_5_1"
eventname.EVENT_CMD_7_0 = "EVENT_CMD_7_0"
eventname.EVENT_CMD_10_4 = "EVENT_CMD_10_4"
eventname.EVENT_CMD_13_0 = "EVENT_CMD_13_0"
eventname.EVENT_CMD_23_6 = "EVENT_CMD_23_6"
eventname.EVENT_CMD_26_10 = "EVENT_CMD_26_10"
eventname.cmds = {
  {
    cmd = "echo",
    cmd_group = 1,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_1_1",
    module_name = "dr2_login_pb",
    req_name = "pbreq_echo",
    rsp_name = "pbrsp_echo"
  },
  {
    cmd = "pub",
    cmd_group = 1,
    cmd_type = 2,
    cmd_name = "EVENT_CMD_1_2",
    module_name = "dr2_login_pb",
    req_name = "pbreq_pub",
    rsp_name = "pbrsp_pub"
  },
  {
    cmd = "reg",
    cmd_group = 2,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_2_1",
    module_name = "dr2_login_pb",
    req_name = "pbreq_reg",
    rsp_name = "pbrsp_reg"
  },
  {
    cmd = "salt",
    cmd_group = 2,
    cmd_type = 2,
    cmd_name = "EVENT_CMD_2_2",
    module_name = "dr2_login_pb",
    req_name = "pbreq_salt",
    rsp_name = "pbrsp_salt"
  },
  {
    cmd = "login",
    cmd_group = 2,
    cmd_type = 3,
    cmd_name = "EVENT_CMD_2_3",
    module_name = "dr2_login_pb",
    req_name = "pbreq_login",
    rsp_name = "pbrsp_login"
  },
  {
    cmd = "thirdlogin",
    cmd_group = 2,
    cmd_type = 4,
    cmd_name = "EVENT_CMD_2_4",
    module_name = "dr2_login_pb",
    req_name = "pbreq_thirdlogin",
    rsp_name = "pbrsp_thirdlogin"
  },
  {
    cmd = "servers_login",
    cmd_group = 2,
    cmd_type = 5,
    cmd_name = "EVENT_CMD_2_5",
    module_name = "dr2_login_pb",
    req_name = "pbreq_servers_login",
    rsp_name = "pbrsp_servers_login"
  },
  {
    cmd = "auth",
    cmd_group = 3,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_3_1",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_auth",
    rsp_name = "pbrsp_auth"
  },
  {
    cmd = "sync",
    cmd_group = 3,
    cmd_type = 2,
    cmd_name = "EVENT_CMD_3_2",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_sync",
    rsp_name = "pbrsp_sync"
  },
  {
    cmd = "up",
    cmd_group = 3,
    cmd_type = 3,
    cmd_name = "EVENT_CMD_3_3",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_up",
    rsp_name = "pbrsp_up"
  },
  {
    cmd = "bind",
    cmd_group = 3,
    cmd_type = 4,
    cmd_name = "EVENT_CMD_3_4",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_bind",
    rsp_name = "pbrsp_bind"
  },
  {
    cmd = "change_password",
    cmd_group = 3,
    cmd_type = 5,
    cmd_name = "EVENT_CMD_3_5",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_change_password",
    rsp_name = "pbrsp_change_password"
  },
  {
    cmd = "servers",
    cmd_group = 3,
    cmd_type = 6,
    cmd_name = "EVENT_CMD_3_6",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_servers",
    rsp_name = "pbrsp_servers"
  },
  {
    cmd = "player",
    cmd_group = 3,
    cmd_type = 7,
    cmd_name = "EVENT_CMD_3_7",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_player",
    rsp_name = "pbrsp_player"
  },
  {
    cmd = "change_name",
    cmd_group = 3,
    cmd_type = 8,
    cmd_name = "EVENT_CMD_3_8",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_change_name",
    rsp_name = "pbrsp_change_name"
  },
  {
    cmd = "change_logo",
    cmd_group = 3,
    cmd_type = 9,
    cmd_name = "EVENT_CMD_3_9",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_change_logo",
    rsp_name = "pbrsp_change_logo"
  },
  {
    cmd = "rate_us",
    cmd_group = 3,
    cmd_type = 10,
    cmd_name = "EVENT_CMD_3_10",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_rate_us",
    rsp_name = "pbrsp_rate_us"
  },
  {
    cmd = "video_ad",
    cmd_group = 3,
    cmd_type = 11,
    cmd_name = "EVENT_CMD_3_11",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_video_ad",
    rsp_name = "pbrsp_video_ad"
  },
  {
    cmd = "cdkey",
    cmd_group = 3,
    cmd_type = 13,
    cmd_name = "EVENT_CMD_3_13",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_cdkey",
    rsp_name = "pbrsp_cdkey"
  },
  {
    cmd = "lpub",
    cmd_group = 3,
    cmd_type = 14,
    cmd_name = "EVENT_CMD_3_14",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_lpub",
    rsp_name = "pbrsp_lpub"
  },
  {
    cmd = "change_border",
    cmd_group = 3,
    cmd_type = 15,
    cmd_name = "EVENT_CMD_3_15",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_change_head_border",
    rsp_name = "pbrsp_change_head_border"
  },
  {
    cmd = "upgrade_border",
    cmd_group = 3,
    cmd_type = 16,
    cmd_name = "EVENT_CMD_3_16",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_upgrade_head_border",
    rsp_name = "pbrsp_upgrade_head_border"
  },
  {
    cmd = "flag_webgame",
    cmd_group = 3,
    cmd_type = 17,
    cmd_name = "EVENT_CMD_3_17",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_flag_webgame",
    rsp_name = "pbrsp_flag_webgame"
  },
  {
    cmd = "smsg",
    cmd_group = 3,
    cmd_type = 18,
    cmd_name = "EVENT_CMD_3_18",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_smsg",
    rsp_name = "pbrsp_smsg"
  },
  {
    cmd = "audit",
    cmd_group = 3,
    cmd_type = 19,
    cmd_name = "EVENT_CMD_3_19",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_audit",
    rsp_name = "pbrsp_audit"
  },
  {
    cmd = "gacha",
    cmd_group = 4,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_4_1",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gacha",
    rsp_name = "pbrsp_gacha"
  },
  {
    cmd = "wear",
    cmd_group = 4,
    cmd_type = 2,
    cmd_name = "EVENT_CMD_4_2",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_wear",
    rsp_name = "pbrsp_wear"
  },
  {
    cmd = "hero_decompose",
    cmd_group = 4,
    cmd_type = 3,
    cmd_name = "EVENT_CMD_4_3",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_hero_decompose",
    rsp_name = "pbrsp_hero_decompose"
  },
  {
    cmd = "hero_merge",
    cmd_group = 4,
    cmd_type = 4,
    cmd_name = "EVENT_CMD_4_4",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_hero_merge",
    rsp_name = "pbrsp_hero_merge"
  },
  {
    cmd = "hero_up",
    cmd_group = 4,
    cmd_type = 5,
    cmd_name = "EVENT_CMD_4_5",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_hero_up",
    rsp_name = "pbrsp_hero_up"
  },
  {
    cmd = "hero_lock",
    cmd_group = 4,
    cmd_type = 6,
    cmd_name = "EVENT_CMD_4_6",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_hero_lock",
    rsp_name = "pbrsp_hero_lock"
  },
  {
    cmd = "hero_mix",
    cmd_group = 4,
    cmd_type = 7,
    cmd_name = "EVENT_CMD_4_7",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_hero_mix",
    rsp_name = "pbrsp_hero_mix"
  },
  {
    cmd = "jade_on",
    cmd_group = 4,
    cmd_type = 8,
    cmd_name = "EVENT_CMD_4_8",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_jade_on",
    rsp_name = "pbrsp_jade_on"
  },
  {
    cmd = "jade_up",
    cmd_group = 4,
    cmd_type = 9,
    cmd_name = "EVENT_CMD_4_9",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_jade_up",
    rsp_name = "pbrsp_jade_up"
  },
  {
    cmd = "jade_change",
    cmd_group = 4,
    cmd_type = 10,
    cmd_name = "EVENT_CMD_4_10",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_jade_change",
    rsp_name = "pbrsp_jade_change"
  },
  {
    cmd = "jade_ok",
    cmd_group = 4,
    cmd_type = 11,
    cmd_name = "EVENT_CMD_4_11",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_jade_ok",
    rsp_name = "pbrsp_jade_ok"
  },
  {
    cmd = "buy_hlimit",
    cmd_group = 4,
    cmd_type = 12,
    cmd_name = "EVENT_CMD_4_12",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_buy_hlimit",
    rsp_name = "pbrsp_buy_hlimit"
  },
  {
    cmd = "transform_hero",
    cmd_group = 4,
    cmd_type = 13,
    cmd_name = "EVENT_CMD_4_13",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_transform_hero",
    rsp_name = "pbrsp_transform_hero"
  },
  {
    cmd = "transform_ok",
    cmd_group = 4,
    cmd_type = 14,
    cmd_name = "EVENT_CMD_4_14",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_transform_ok",
    rsp_name = "pbrsp_transform_ok"
  },
  {
    cmd = "hero_wake",
    cmd_group = 4,
    cmd_type = 15,
    cmd_name = "EVENT_CMD_4_15",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_hero_wake",
    rsp_name = "pbrsp_hero_wake"
  },
  {
    cmd = "hero_change",
    cmd_group = 4,
    cmd_type = 16,
    cmd_name = "EVENT_CMD_4_16",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_hero_change",
    rsp_name = "pbrsp_hero_change"
  },
  {
    cmd = "hero_skin_mix",
    cmd_group = 4,
    cmd_type = 17,
    cmd_name = "EVENT_CMD_4_17",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_hero_skin_mix",
    rsp_name = "pbrsp_hero_skin_mix"
  },
  {
    cmd = "hero_skin_wear",
    cmd_group = 4,
    cmd_type = 18,
    cmd_name = "EVENT_CMD_4_18",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_hero_skin_wear",
    rsp_name = "pbrsp_hero_skin_wear"
  },
  {
    cmd = "hero_skin_off",
    cmd_group = 4,
    cmd_type = 19,
    cmd_name = "EVENT_CMD_4_19",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_hero_skin_off",
    rsp_name = "pbrsp_hero_skin_off"
  },
  {
    cmd = "shield_change",
    cmd_group = 4,
    cmd_type = 20,
    cmd_name = "EVENT_CMD_4_20",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_shield_change",
    rsp_name = "pbrsp_shield_change"
  },
  {
    cmd = "hero_skin_visit",
    cmd_group = 4,
    cmd_type = 21,
    cmd_name = "EVENT_CMD_4_21",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_hero_skin_visit",
    rsp_name = "pbrsp_hero_skin_visit"
  },
  {
    cmd = "hero_skin_breakdown",
    cmd_group = 4,
    cmd_type = 22,
    cmd_name = "EVENT_CMD_4_22",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_hero_skin_breakdown",
    rsp_name = "pbrsp_hero_skin_breakdown"
  },
  {
    cmd = "hero_talen",
    cmd_group = 4,
    cmd_type = 23,
    cmd_name = "EVENT_CMD_4_23",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_hero_talen",
    rsp_name = "pbrsp_hero_talen"
  },
  {
    cmd = "hero_talenop",
    cmd_group = 4,
    cmd_type = 24,
    cmd_name = "EVENT_CMD_4_24",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_hero_talenop",
    rsp_name = "pbrsp_hero_talenop"
  },
  {
    cmd = "hero_return",
    cmd_group = 4,
    cmd_type = 25,
    cmd_name = "EVENT_CMD_4_25",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_hero_return",
    rsp_name = "pbrsp_hero_return"
  },
  {
    cmd = "hero_skin_limitmix",
    cmd_group = 4,
    cmd_type = 26,
    cmd_name = "EVENT_CMD_4_26",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_hero_skin_limitmix",
    rsp_name = "pbrsp_hero_skin_limitmix"
  },
  {
    cmd = "hero_skin_up",
    cmd_group = 4,
    cmd_type = 27,
    cmd_name = "EVENT_CMD_4_27",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_hero_skin_up",
    rsp_name = "pbrsp_hero_skin_up"
  },
  {
    cmd = "hero_ticket",
    cmd_group = 4,
    cmd_type = 28,
    cmd_name = "EVENT_CMD_4_28",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_hero_ticket",
    rsp_name = "pbrsp_hero_ticket"
  },
  {
    cmd = "jade_unlock",
    cmd_group = 4,
    cmd_type = 29,
    cmd_name = "EVENT_CMD_4_29",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_jade_unlock",
    rsp_name = "pbrsp_jade_unlock"
  },
  {
    cmd = "jade_used",
    cmd_group = 4,
    cmd_type = 30,
    cmd_name = "EVENT_CMD_4_30",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_jade_used",
    rsp_name = "pbrsp_jade_used"
  },
  {
    cmd = "auto_lvup",
    cmd_group = 4,
    cmd_type = 31,
    cmd_name = "EVENT_CMD_4_31",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_auto_lvup",
    rsp_name = "pbrsp_auto_lvup"
  },
  {
    cmd = "op_mail",
    cmd_group = 5,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_5_1",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_op_mail",
    rsp_name = "pbrsp_op_mail"
  },
  {
    cmd = "send_mail",
    cmd_group = 5,
    cmd_type = 2,
    cmd_name = "EVENT_CMD_5_2",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_send_mail",
    rsp_name = "pbrsp_send_mail"
  },
  {
    cmd = "sell",
    cmd_group = 6,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_6_1",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_sell",
    rsp_name = "pbrsp_sell"
  },
  {
    cmd = "midas",
    cmd_group = 6,
    cmd_type = 2,
    cmd_name = "EVENT_CMD_6_2",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_midas",
    rsp_name = "pbrsp_midas"
  },
  {
    cmd = "enchant",
    cmd_group = 6,
    cmd_type = 3,
    cmd_name = "EVENT_CMD_6_3",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_enchant",
    rsp_name = "pbrsp_enchant"
  },
  {
    cmd = "up_treasure",
    cmd_group = 6,
    cmd_type = 4,
    cmd_name = "EVENT_CMD_6_4",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_up_treasure",
    rsp_name = "pbrsp_up_treasure"
  },
  {
    cmd = "equip_merge",
    cmd_group = 6,
    cmd_type = 5,
    cmd_name = "EVENT_CMD_6_5",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_equip_merge",
    rsp_name = "pbrsp_equip_merge"
  },
  {
    cmd = "exchange_act",
    cmd_group = 6,
    cmd_type = 6,
    cmd_name = "EVENT_CMD_6_6",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_exchange_act",
    rsp_name = "pbrsp_exchange_act"
  },
  {
    cmd = "open_gift",
    cmd_group = 6,
    cmd_type = 7,
    cmd_name = "EVENT_CMD_6_7",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_open_gift",
    rsp_name = "pbrsp_open_gift"
  },
  {
    cmd = "dwarf",
    cmd_group = 6,
    cmd_type = 8,
    cmd_name = "EVENT_CMD_6_8",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_dwarf",
    rsp_name = "pbrsp_dwarf"
  },
  {
    cmd = "equip_resolve",
    cmd_group = 6,
    cmd_type = 9,
    cmd_name = "EVENT_CMD_6_9",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_equip_resolve",
    rsp_name = "pbrsp_equip_resolve"
  },
  {
    cmd = "equip_soul",
    cmd_group = 6,
    cmd_type = 10,
    cmd_name = "EVENT_CMD_6_10",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_equip_soul",
    rsp_name = "pbrsp_equip_soul"
  },
  {
    cmd = "equip_soul_ok",
    cmd_group = 6,
    cmd_type = 11,
    cmd_name = "EVENT_CMD_6_11",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_equip_soul_ok",
    rsp_name = "pbrsp_equip_soul_ok"
  },
  {
    cmd = "equip_soul_sync",
    cmd_group = 6,
    cmd_type = 12,
    cmd_name = "EVENT_CMD_6_12",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_equip_soul_sync",
    rsp_name = "pbrsp_equip_soul_sync"
  },
  {
    cmd = "dwarf_change",
    cmd_group = 6,
    cmd_type = 13,
    cmd_name = "EVENT_CMD_6_13",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_dwarf_change",
    rsp_name = "pbrsp_dwarf_change"
  },
  {
    cmd = "sync_chat",
    cmd_group = 7,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_7_1",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_sync_chat",
    rsp_name = "pbrsp_sync_chat"
  },
  {
    cmd = "chat",
    cmd_group = 7,
    cmd_type = 2,
    cmd_name = "EVENT_CMD_7_2",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_chat",
    rsp_name = "pbrsp_chat"
  },
  {
    cmd = "cunit",
    cmd_group = 7,
    cmd_type = 3,
    cmd_name = "EVENT_CMD_7_3",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_cunit",
    rsp_name = "pbrsp_cunit"
  },
  {
    cmd = "block_chat",
    cmd_group = 7,
    cmd_type = 4,
    cmd_name = "EVENT_CMD_7_4",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_block_chat",
    rsp_name = "pbrsp_block_chat"
  },
  {
    cmd = "hide_vip",
    cmd_group = 7,
    cmd_type = 5,
    cmd_name = "EVENT_CMD_7_5",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_hide_vip",
    rsp_name = "pbrsp_hide_vip"
  },
  {
    cmd = "translate",
    cmd_group = 7,
    cmd_type = 6,
    cmd_name = "EVENT_CMD_7_6",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_translate",
    rsp_name = "pbrsp_translate"
  },
  {
    cmd = "chat_setting",
    cmd_group = 7,
    cmd_type = 7,
    cmd_name = "EVENT_CMD_7_7",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_chat_setting",
    rsp_name = "pbrsp_chat_setting"
  },
  {
    cmd = "resolve_block_chat",
    cmd_group = 7,
    cmd_type = 8,
    cmd_name = "EVENT_CMD_7_8",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_resolve_block_chat",
    rsp_name = "pbrsp_resolve_block_chat"
  },
  {
    cmd = "get_block_chat",
    cmd_group = 7,
    cmd_type = 9,
    cmd_name = "EVENT_CMD_7_9",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_get_block_chat",
    rsp_name = "pbrsp_get_block_chat"
  },
  {
    cmd = "report",
    cmd_group = 7,
    cmd_type = 12,
    cmd_name = "EVENT_CMD_7_12",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_report",
    rsp_name = "pbrsp_report"
  },
  {
    cmd = "bmarket_pull",
    cmd_group = 8,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_8_1",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_bmarket_pull",
    rsp_name = "pbrsp_bmarket_pull"
  },
  {
    cmd = "bmarket_buy",
    cmd_group = 8,
    cmd_type = 2,
    cmd_name = "EVENT_CMD_8_2",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_bmarket_buy",
    rsp_name = "pbrsp_bmarket_buy"
  },
  {
    cmd = "hook_init",
    cmd_group = 9,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_9_1",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_hook_init",
    rsp_name = "pbrsp_hook_init"
  },
  {
    cmd = "hook_change",
    cmd_group = 9,
    cmd_type = 2,
    cmd_name = "EVENT_CMD_9_2",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_hook_change",
    rsp_name = "pbrsp_hook_change"
  },
  {
    cmd = "hook_ask",
    cmd_group = 9,
    cmd_type = 3,
    cmd_name = "EVENT_CMD_9_3",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_hook_ask",
    rsp_name = "pbrsp_hook_ask"
  },
  {
    cmd = "hook_reward",
    cmd_group = 9,
    cmd_type = 4,
    cmd_name = "EVENT_CMD_9_4",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_hook_reward",
    rsp_name = "pbrsp_hook_reward"
  },
  {
    cmd = "hook_heroes",
    cmd_group = 9,
    cmd_type = 5,
    cmd_name = "EVENT_CMD_9_5",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_hook_heroes",
    rsp_name = "pbrsp_hook_heroes"
  },
  {
    cmd = "test_fight",
    cmd_group = 9,
    cmd_type = 6,
    cmd_name = "EVENT_CMD_9_6",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_test_fight",
    rsp_name = "pbrsp_test_fight"
  },
  {
    cmd = "pve",
    cmd_group = 9,
    cmd_type = 7,
    cmd_name = "EVENT_CMD_9_7",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_pve",
    rsp_name = "pbrsp_pve"
  },
  {
    cmd = "dare_sync",
    cmd_group = 9,
    cmd_type = 8,
    cmd_name = "EVENT_CMD_9_8",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_dare_sync",
    rsp_name = "pbrsp_dare_sync"
  },
  {
    cmd = "dare_buy",
    cmd_group = 9,
    cmd_type = 9,
    cmd_name = "EVENT_CMD_9_9",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_dare_buy",
    rsp_name = "pbrsp_dare_buy"
  },
  {
    cmd = "dare_fight",
    cmd_group = 9,
    cmd_type = 10,
    cmd_name = "EVENT_CMD_9_10",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_dare_fight",
    rsp_name = "pbrsp_dare_fight"
  },
  {
    cmd = "sync_brave",
    cmd_group = 9,
    cmd_type = 11,
    cmd_name = "EVENT_CMD_9_11",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_sync_brave",
    rsp_name = "pbrsp_sync_brave"
  },
  {
    cmd = "brave_fight",
    cmd_group = 9,
    cmd_type = 12,
    cmd_name = "EVENT_CMD_9_12",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_brave_fight",
    rsp_name = "pbrsp_brave_fight"
  },
  {
    cmd = "brave_pull",
    cmd_group = 9,
    cmd_type = 13,
    cmd_name = "EVENT_CMD_9_13",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_brave_pull",
    rsp_name = "pbrsp_brave_pull"
  },
  {
    cmd = "brave_node",
    cmd_group = 9,
    cmd_type = 14,
    cmd_name = "EVENT_CMD_9_14",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_brave_node",
    rsp_name = "pbrsp_brave_node"
  },
  {
    cmd = "pve_rank",
    cmd_group = 9,
    cmd_type = 15,
    cmd_name = "EVENT_CMD_9_15",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_pve_rank",
    rsp_name = "pbrsp_pve_rank"
  },
  {
    cmd = "frd_sync",
    cmd_group = 10,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_10_1",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_frd_sync",
    rsp_name = "pbrsp_frd_sync"
  },
  {
    cmd = "frd_op",
    cmd_group = 10,
    cmd_type = 2,
    cmd_name = "EVENT_CMD_10_2",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_frd_op",
    rsp_name = "pbrsp_frd_op"
  },
  {
    cmd = "frd_love",
    cmd_group = 10,
    cmd_type = 3,
    cmd_name = "EVENT_CMD_10_3",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_frd_love",
    rsp_name = "pbrsp_frd_love"
  },
  {
    cmd = "frd_notify",
    cmd_group = 10,
    cmd_type = 4,
    cmd_name = "EVENT_CMD_10_4",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_frd_notify",
    rsp_name = "pbrsp_frd_notify"
  },
  {
    cmd = "frd_pk",
    cmd_group = 10,
    cmd_type = 5,
    cmd_name = "EVENT_CMD_10_5",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_frd_pk",
    rsp_name = "pbrsp_frd_pk"
  },
  {
    cmd = "frd_advise",
    cmd_group = 10,
    cmd_type = 6,
    cmd_name = "EVENT_CMD_10_6",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_frd_advise",
    rsp_name = "pbrsp_frd_advise"
  },
  {
    cmd = "pull_casino",
    cmd_group = 11,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_11_1",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_pull_casino",
    rsp_name = "pbrsp_pull_casino"
  },
  {
    cmd = "casino_msg",
    cmd_group = 11,
    cmd_type = 2,
    cmd_name = "EVENT_CMD_11_2",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_casino_msg",
    rsp_name = "pbrsp_casino_msg"
  },
  {
    cmd = "casino_draw",
    cmd_group = 11,
    cmd_type = 3,
    cmd_name = "EVENT_CMD_11_3",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_casino_draw",
    rsp_name = "pbrsp_casino_draw"
  },
  {
    cmd = "casino_buy",
    cmd_group = 11,
    cmd_type = 4,
    cmd_name = "EVENT_CMD_11_4",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_casino_buy",
    rsp_name = "pbrsp_casino_buy"
  },
  {
    cmd = "lmarket_pull",
    cmd_group = 12,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_12_1",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_lmarket_pull",
    rsp_name = "pbrsp_lmarket_pull"
  },
  {
    cmd = "lmarket_buy",
    cmd_group = 12,
    cmd_type = 2,
    cmd_name = "EVENT_CMD_12_2",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_lmarket_buy",
    rsp_name = "pbrsp_lmarket_buy"
  },
  {
    cmd = "guild_sync",
    cmd_group = 13,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_13_1",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_guild_sync",
    rsp_name = "pbrsp_guild_sync"
  },
  {
    cmd = "guild_rank",
    cmd_group = 13,
    cmd_type = 2,
    cmd_name = "EVENT_CMD_13_2",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_guild_rank",
    rsp_name = "pbrsp_guild_rank"
  },
  {
    cmd = "glog",
    cmd_group = 13,
    cmd_type = 3,
    cmd_name = "EVENT_CMD_13_3",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_glog",
    rsp_name = "pbrsp_glog"
  },
  {
    cmd = "guild_create",
    cmd_group = 13,
    cmd_type = 4,
    cmd_name = "EVENT_CMD_13_4",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_guild_create",
    rsp_name = "pbrsp_guild_create"
  },
  {
    cmd = "guild_notice",
    cmd_group = 13,
    cmd_type = 5,
    cmd_name = "EVENT_CMD_13_5",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_guild_notice",
    rsp_name = "pbrsp_guild_notice"
  },
  {
    cmd = "guild_flag",
    cmd_group = 13,
    cmd_type = 6,
    cmd_name = "EVENT_CMD_13_6",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_guild_flag",
    rsp_name = "pbrsp_guild_flag"
  },
  {
    cmd = "guild_name",
    cmd_group = 13,
    cmd_type = 7,
    cmd_name = "EVENT_CMD_13_7",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_guild_name",
    rsp_name = "pbrsp_guild_name"
  },
  {
    cmd = "guild_dismiss",
    cmd_group = 13,
    cmd_type = 8,
    cmd_name = "EVENT_CMD_13_8",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_guild_dismiss",
    rsp_name = "pbrsp_guild_dismiss"
  },
  {
    cmd = "guild_apply",
    cmd_group = 13,
    cmd_type = 9,
    cmd_name = "EVENT_CMD_13_9",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_guild_apply",
    rsp_name = "pbrsp_guild_apply"
  },
  {
    cmd = "guild_leave",
    cmd_group = 13,
    cmd_type = 10,
    cmd_name = "EVENT_CMD_13_10",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_guild_leave",
    rsp_name = "pbrsp_guild_leave"
  },
  {
    cmd = "guild_sign",
    cmd_group = 13,
    cmd_type = 11,
    cmd_name = "EVENT_CMD_13_11",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_guild_sign",
    rsp_name = "pbrsp_guild_sign"
  },
  {
    cmd = "guild_recommend",
    cmd_group = 13,
    cmd_type = 12,
    cmd_name = "EVENT_CMD_13_12",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_guild_recommend",
    rsp_name = "pbrsp_guild_recommend"
  },
  {
    cmd = "guild_search",
    cmd_group = 13,
    cmd_type = 13,
    cmd_name = "EVENT_CMD_13_13",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_guild_search",
    rsp_name = "pbrsp_guild_search"
  },
  {
    cmd = "guild_appliers",
    cmd_group = 13,
    cmd_type = 14,
    cmd_name = "EVENT_CMD_13_14",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_guild_appliers",
    rsp_name = "pbrsp_guild_appliers"
  },
  {
    cmd = "gmember_opt",
    cmd_group = 13,
    cmd_type = 15,
    cmd_name = "EVENT_CMD_13_15",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gmember_opt",
    rsp_name = "pbrsp_gmember_opt"
  },
  {
    cmd = "gboss_sync",
    cmd_group = 13,
    cmd_type = 16,
    cmd_name = "EVENT_CMD_13_16",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gboss_sync",
    rsp_name = "pbrsp_gboss_sync"
  },
  {
    cmd = "gboss_rank",
    cmd_group = 13,
    cmd_type = 17,
    cmd_name = "EVENT_CMD_13_17",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gboss_rank",
    rsp_name = "pbrsp_gboss_rank"
  },
  {
    cmd = "gboss_fight",
    cmd_group = 13,
    cmd_type = 18,
    cmd_name = "EVENT_CMD_13_18",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gboss_fight",
    rsp_name = "pbrsp_gboss_fight"
  },
  {
    cmd = "gskl_sync",
    cmd_group = 13,
    cmd_type = 19,
    cmd_name = "EVENT_CMD_13_19",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gskl_sync",
    rsp_name = "pbrsp_gskl_sync"
  },
  {
    cmd = "gskl_up",
    cmd_group = 13,
    cmd_type = 20,
    cmd_name = "EVENT_CMD_13_20",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gskl_up",
    rsp_name = "pbrsp_gskl_up"
  },
  {
    cmd = "gmill_sync",
    cmd_group = 13,
    cmd_type = 21,
    cmd_name = "EVENT_CMD_13_21",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gmill_sync",
    rsp_name = "pbrsp_gmill_sync"
  },
  {
    cmd = "gmill_order",
    cmd_group = 13,
    cmd_type = 22,
    cmd_name = "EVENT_CMD_13_22",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gmill_order",
    rsp_name = "pbrsp_gmill_order"
  },
  {
    cmd = "gmill_uporder",
    cmd_group = 13,
    cmd_type = 23,
    cmd_name = "EVENT_CMD_13_23",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gmill_uporder",
    rsp_name = "pbrsp_gmill_uporder"
  },
  {
    cmd = "gmill_start",
    cmd_group = 13,
    cmd_type = 24,
    cmd_name = "EVENT_CMD_13_24",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gmill_start",
    rsp_name = "pbrsp_gmill_start"
  },
  {
    cmd = "gmill_claim",
    cmd_group = 13,
    cmd_type = 25,
    cmd_name = "EVENT_CMD_13_25",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gmill_claim",
    rsp_name = "pbrsp_gmill_claim"
  },
  {
    cmd = "gmill_olog",
    cmd_group = 13,
    cmd_type = 26,
    cmd_name = "EVENT_CMD_13_26",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gmill_olog",
    rsp_name = "pbrsp_gmill_olog"
  },
  {
    cmd = "donate_sync",
    cmd_group = 13,
    cmd_type = 27,
    cmd_name = "EVENT_CMD_13_27",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_donate_sync",
    rsp_name = "pbrsp_donate_sync"
  },
  {
    cmd = "donate_up",
    cmd_group = 13,
    cmd_type = 28,
    cmd_name = "EVENT_CMD_13_28",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_donate_up",
    rsp_name = "pbrsp_donate_up"
  },
  {
    cmd = "donate_log",
    cmd_group = 13,
    cmd_type = 29,
    cmd_name = "EVENT_CMD_13_29",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_donate_log",
    rsp_name = "pbrsp_donate_log"
  },
  {
    cmd = "gmill_donaterank",
    cmd_group = 13,
    cmd_type = 30,
    cmd_name = "EVENT_CMD_13_30",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gmill_donaterank",
    rsp_name = "pbrsp_gmill_donaterank"
  },
  {
    cmd = "gskl_reset",
    cmd_group = 13,
    cmd_type = 31,
    cmd_name = "EVENT_CMD_13_31",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gskl_reset",
    rsp_name = "pbrsp_gskl_reset"
  },
  {
    cmd = "gfire_sync",
    cmd_group = 13,
    cmd_type = 34,
    cmd_name = "EVENT_CMD_13_34",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gfire_sync",
    rsp_name = "pbrsp_gfire_sync"
  },
  {
    cmd = "gfire_reg",
    cmd_group = 13,
    cmd_type = 35,
    cmd_name = "EVENT_CMD_13_35",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gfire_reg",
    rsp_name = "pbrsp_gfire_reg"
  },
  {
    cmd = "gfire_fight",
    cmd_group = 13,
    cmd_type = 36,
    cmd_name = "EVENT_CMD_13_36",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gfire_fight",
    rsp_name = "pbrsp_gfire_fight"
  },
  {
    cmd = "gfire_rank",
    cmd_group = 13,
    cmd_type = 37,
    cmd_name = "EVENT_CMD_13_37",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gfire_rank",
    rsp_name = "pbrsp_gfire_rank"
  },
  {
    cmd = "gfire_donate_rank",
    cmd_group = 13,
    cmd_type = 38,
    cmd_name = "EVENT_CMD_13_38",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gfire_donate_rank",
    rsp_name = "pbrsp_gfire_donate_rank"
  },
  {
    cmd = "gve_sync",
    cmd_group = 13,
    cmd_type = 38,
    cmd_name = "EVENT_CMD_13_38",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gve_sync",
    rsp_name = "pbrsp_gve_sync"
  },
  {
    cmd = "gve_rank",
    cmd_group = 13,
    cmd_type = 39,
    cmd_name = "EVENT_CMD_13_39",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gve_rank",
    rsp_name = "pbrsp_gve_rank"
  },
  {
    cmd = "gve_fight",
    cmd_group = 13,
    cmd_type = 40,
    cmd_name = "EVENT_CMD_13_40",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gve_fight",
    rsp_name = "pbrsp_gve_fight"
  },
  {
    cmd = "gve_task",
    cmd_group = 13,
    cmd_type = 41,
    cmd_name = "EVENT_CMD_13_41",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gve_task",
    rsp_name = "pbrsp_gve_task"
  },
  {
    cmd = "gve_claim",
    cmd_group = 13,
    cmd_type = 42,
    cmd_name = "EVENT_CMD_13_42",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gve_claim",
    rsp_name = "pbrsp_gve_claim"
  },
  {
    cmd = "gve_map_claim",
    cmd_group = 13,
    cmd_type = 43,
    cmd_name = "EVENT_CMD_13_43",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gve_map_claim",
    rsp_name = "pbrsp_gve_map_claim"
  },
  {
    cmd = "trial",
    cmd_group = 14,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_14_1",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_trial",
    rsp_name = "pbrsp_trial"
  },
  {
    cmd = "trial_rank",
    cmd_group = 14,
    cmd_type = 2,
    cmd_name = "EVENT_CMD_14_2",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_trial_rank",
    rsp_name = "pbrsp_trial_rank"
  },
  {
    cmd = "trial_fight",
    cmd_group = 14,
    cmd_type = 3,
    cmd_name = "EVENT_CMD_14_3",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_trial_fight",
    rsp_name = "pbrsp_trial_fight"
  },
  {
    cmd = "trial_video",
    cmd_group = 14,
    cmd_type = 4,
    cmd_name = "EVENT_CMD_14_4",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_trial_video",
    rsp_name = "pbrsp_trial_video"
  },
  {
    cmd = "trial_tl",
    cmd_group = 14,
    cmd_type = 5,
    cmd_name = "EVENT_CMD_14_5",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_trial_tl",
    rsp_name = "pbrsp_trial_tl"
  },
  {
    cmd = "pvp_sync",
    cmd_group = 15,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_15_1",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_pvp_sync",
    rsp_name = "pbrsp_pvp_sync"
  },
  {
    cmd = "pvp_camp",
    cmd_group = 15,
    cmd_type = 2,
    cmd_name = "EVENT_CMD_15_2",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_pvp_camp",
    rsp_name = "pbrsp_pvp_camp"
  },
  {
    cmd = "pvp_refresh",
    cmd_group = 15,
    cmd_type = 3,
    cmd_name = "EVENT_CMD_15_3",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_pvp_refresh",
    rsp_name = "pbrsp_pvp_refresh"
  },
  {
    cmd = "pvp_fight",
    cmd_group = 15,
    cmd_type = 4,
    cmd_name = "EVENT_CMD_15_4",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_pvp_fight",
    rsp_name = "pbrsp_pvp_fight"
  },
  {
    cmd = "plogs",
    cmd_group = 15,
    cmd_type = 5,
    cmd_name = "EVENT_CMD_15_5",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_plogs",
    rsp_name = "pbrsp_plogs"
  },
  {
    cmd = "pvp_rank",
    cmd_group = 15,
    cmd_type = 6,
    cmd_name = "EVENT_CMD_15_6",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_pvp_rank",
    rsp_name = "pbrsp_pvp_rank"
  },
  {
    cmd = "video",
    cmd_group = 15,
    cmd_type = 7,
    cmd_name = "EVENT_CMD_15_7",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_video",
    rsp_name = "pbrsp_video"
  },
  {
    cmd = "pvp_ticket",
    cmd_group = 15,
    cmd_type = 8,
    cmd_name = "EVENT_CMD_15_8",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_pvp_ticket",
    rsp_name = "pbrsp_pvp_ticket"
  },
  {
    cmd = "pmarket",
    cmd_group = 15,
    cmd_type = 9,
    cmd_name = "EVENT_CMD_15_9",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_pmarket",
    rsp_name = "pbrsp_pmarket"
  },
  {
    cmd = "pmarket_buy",
    cmd_group = 15,
    cmd_type = 10,
    cmd_name = "EVENT_CMD_15_10",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_pmarket_buy",
    rsp_name = "pbrsp_pmarket_buy"
  },
  {
    cmd = "joinpvp_sync",
    cmd_group = 15,
    cmd_type = 11,
    cmd_name = "EVENT_CMD_15_11",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_joinpvp_sync",
    rsp_name = "pbrsp_joinpvp_sync"
  },
  {
    cmd = "p3p_sync",
    cmd_group = 15,
    cmd_type = 12,
    cmd_name = "EVENT_CMD_15_12",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_p3p_sync",
    rsp_name = "pbrsp_p3p_sync"
  },
  {
    cmd = "p3p_camp",
    cmd_group = 15,
    cmd_type = 13,
    cmd_name = "EVENT_CMD_15_13",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_p3p_camp",
    rsp_name = "pbrsp_p3p_camp"
  },
  {
    cmd = "p3p_match",
    cmd_group = 15,
    cmd_type = 14,
    cmd_name = "EVENT_CMD_15_14",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_p3p_match",
    rsp_name = "pbrsp_p3p_match"
  },
  {
    cmd = "p3p_fight",
    cmd_group = 15,
    cmd_type = 15,
    cmd_name = "EVENT_CMD_15_15",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_p3p_fight",
    rsp_name = "pbrsp_p3p_fight"
  },
  {
    cmd = "p3p_honor",
    cmd_group = 15,
    cmd_type = 16,
    cmd_name = "EVENT_CMD_15_16",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_p3p_honor",
    rsp_name = "pbrsp_p3p_honor"
  },
  {
    cmd = "p3p_logs",
    cmd_group = 15,
    cmd_type = 17,
    cmd_name = "EVENT_CMD_15_17",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_p3p_logs",
    rsp_name = "pbrsp_p3p_logs"
  },
  {
    cmd = "p3p_video",
    cmd_group = 15,
    cmd_type = 18,
    cmd_name = "EVENT_CMD_15_18",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_p3p_video",
    rsp_name = "pbrsp_p3p_video"
  },
  {
    cmd = "p3p_info",
    cmd_group = 15,
    cmd_type = 19,
    cmd_name = "EVENT_CMD_15_19",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_p3p_info",
    rsp_name = "pbrsp_p3p_info"
  },
  {
    cmd = "fpk_camp",
    cmd_group = 15,
    cmd_type = 20,
    cmd_name = "EVENT_CMD_15_20",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_fpk_camp",
    rsp_name = "pbrsp_fpk_camp"
  },
  {
    cmd = "htask",
    cmd_group = 16,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_16_1",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_htask",
    rsp_name = "pbrsp_htask"
  },
  {
    cmd = "htask_start",
    cmd_group = 16,
    cmd_type = 2,
    cmd_name = "EVENT_CMD_16_2",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_htask_start",
    rsp_name = "pbrsp_htask_start"
  },
  {
    cmd = "htask_speedup",
    cmd_group = 16,
    cmd_type = 3,
    cmd_name = "EVENT_CMD_16_3",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_htask_speedup",
    rsp_name = "pbrsp_htask_speedup"
  },
  {
    cmd = "htask_rec",
    cmd_group = 16,
    cmd_type = 4,
    cmd_name = "EVENT_CMD_16_4",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_htask_rec",
    rsp_name = "pbrsp_htask_rec"
  },
  {
    cmd = "htask_gem",
    cmd_group = 16,
    cmd_type = 5,
    cmd_name = "EVENT_CMD_16_5",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_htask_gem",
    rsp_name = "pbrsp_htask_gem"
  },
  {
    cmd = "htask_lock",
    cmd_group = 16,
    cmd_type = 6,
    cmd_name = "EVENT_CMD_16_6",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_htask_lock",
    rsp_name = "pbrsp_htask_lock"
  },
  {
    cmd = "htask_add",
    cmd_group = 16,
    cmd_type = 7,
    cmd_name = "EVENT_CMD_16_7",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_htask_add",
    rsp_name = "pbrsp_htask_add"
  },
  {
    cmd = "htask_auto",
    cmd_group = 16,
    cmd_type = 8,
    cmd_name = "EVENT_CMD_16_8",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_htask_auto",
    rsp_name = "pbrsp_htask_auto"
  },
  {
    cmd = "achieve",
    cmd_group = 17,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_17_1",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_achieve",
    rsp_name = "pbrsp_achieve"
  },
  {
    cmd = "achieve_claim",
    cmd_group = 17,
    cmd_type = 2,
    cmd_name = "EVENT_CMD_17_2",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_achieve_claim",
    rsp_name = "pbrsp_achieve_claim"
  },
  {
    cmd = "achievie_attention",
    cmd_group = 17,
    cmd_type = 3,
    cmd_name = "EVENT_CMD_17_3",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_achievie_attention",
    rsp_name = "pbrsp_achievie_attention"
  },
  {
    cmd = "pay",
    cmd_group = 18,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_18_1",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_pay",
    rsp_name = "pbrsp_pay"
  },
  {
    cmd = "fpay",
    cmd_group = 18,
    cmd_type = 2,
    cmd_name = "EVENT_CMD_18_2",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_fpay",
    rsp_name = "pbrsp_fpay"
  },
  {
    cmd = "pay2",
    cmd_group = 18,
    cmd_type = 3,
    cmd_name = "EVENT_CMD_18_3",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_pay2",
    rsp_name = "pbrsp_pay2"
  },
  {
    cmd = "gorder",
    cmd_group = 18,
    cmd_type = 4,
    cmd_name = "EVENT_CMD_18_4",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gorder",
    rsp_name = "pbrsp_gorder"
  },
  {
    cmd = "gpay",
    cmd_group = 18,
    cmd_type = 5,
    cmd_name = "EVENT_CMD_18_5",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gpay",
    rsp_name = "pbrsp_gpay"
  },
  {
    cmd = "chpay",
    cmd_group = 18,
    cmd_type = 6,
    cmd_name = "EVENT_CMD_18_6",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_chpay",
    rsp_name = "pbrsp_chpay"
  },
  {
    cmd = "amznpay",
    cmd_group = 18,
    cmd_type = 7,
    cmd_name = "EVENT_CMD_18_7",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_amznpay",
    rsp_name = "pbrsp_amznpay"
  },
  {
    cmd = "oneforum",
    cmd_group = 18,
    cmd_type = 10,
    cmd_name = "EVENT_CMD_18_10",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_oneforum",
    rsp_name = "pbrsp_oneforum"
  },
  {
    cmd = "gpay2",
    cmd_group = 18,
    cmd_type = 11,
    cmd_name = "EVENT_CMD_18_11",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gpay2",
    rsp_name = "pbrsp_gpay2"
  },
  {
    cmd = "voucher",
    cmd_group = 18,
    cmd_type = 12,
    cmd_name = "EVENT_CMD_18_12",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_voucher",
    rsp_name = "pbrsp_voucher"
  },
  {
    cmd = "storeinfo",
    cmd_group = 18,
    cmd_type = 13,
    cmd_name = "EVENT_CMD_18_13",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_storeinfo",
    rsp_name = "pbrsp_storeinfo"
  },
  {
    cmd = "hmarket_buy",
    cmd_group = 19,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_19_1",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_hmarket_buy",
    rsp_name = "pbrsp_hmarket_buy"
  },
  {
    cmd = "hmarket_sync",
    cmd_group = 19,
    cmd_type = 2,
    cmd_name = "EVENT_CMD_19_2",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_hmarket_sync",
    rsp_name = "pbrsp_hmarket_sync"
  },
  {
    cmd = "brave_market_buy",
    cmd_group = 19,
    cmd_type = 3,
    cmd_name = "EVENT_CMD_19_3",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_brave_market_buy",
    rsp_name = "pbrsp_brave_market_buy"
  },
  {
    cmd = "brave_market_sync",
    cmd_group = 19,
    cmd_type = 4,
    cmd_name = "EVENT_CMD_19_4",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_brave_market_sync",
    rsp_name = "pbrsp_brave_market_sync"
  },
  {
    cmd = "hmarket_refresh",
    cmd_group = 19,
    cmd_type = 5,
    cmd_name = "EVENT_CMD_19_5",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_hmarket_refresh",
    rsp_name = "pbrsp_hmarket_refresh"
  },
  {
    cmd = "alogin",
    cmd_group = 20,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_20_1",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_alogin",
    rsp_name = "pbrsp_alogin"
  },
  {
    cmd = "task_claim",
    cmd_group = 20,
    cmd_type = 2,
    cmd_name = "EVENT_CMD_20_2",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_task_claim",
    rsp_name = "pbrsp_task_claim"
  },
  {
    cmd = "online_claim",
    cmd_group = 20,
    cmd_type = 3,
    cmd_name = "EVENT_CMD_20_3",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_online_claim",
    rsp_name = "pbrsp_online_claim"
  },
  {
    cmd = "feedback",
    cmd_group = 21,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_21_1",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_feedback",
    rsp_name = "pbrsp_feedback"
  },
  {
    cmd = "gmarket_buy",
    cmd_group = 22,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_22_1",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gmarket_buy",
    rsp_name = "pbrsp_gmarket_buy"
  },
  {
    cmd = "gmarket_sync",
    cmd_group = 22,
    cmd_type = 2,
    cmd_name = "EVENT_CMD_22_2",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gmarket_sync",
    rsp_name = "pbrsp_gmarket_sync"
  },
  {
    cmd = "gmarket_refresh",
    cmd_group = 22,
    cmd_type = 3,
    cmd_name = "EVENT_CMD_22_3",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gmarket_refresh",
    rsp_name = "pbrsp_gmarket_refresh"
  },
  {
    cmd = "gmarket_exchange",
    cmd_group = 22,
    cmd_type = 4,
    cmd_name = "EVENT_CMD_22_4",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gmarket_exchange",
    rsp_name = "pbrsp_gmarket_exchange"
  },
  {
    cmd = "frd_boss_st",
    cmd_group = 23,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_23_1",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_frd_boss_st",
    rsp_name = "pbrsp_frd_boss_st"
  },
  {
    cmd = "frd_boss_search",
    cmd_group = 23,
    cmd_type = 2,
    cmd_name = "EVENT_CMD_23_2",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_frd_boss_search",
    rsp_name = "pbrsp_frd_boss_search"
  },
  {
    cmd = "frd_boss_fight",
    cmd_group = 23,
    cmd_type = 3,
    cmd_name = "EVENT_CMD_23_3",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_frd_boss_fight",
    rsp_name = "pbrsp_frd_boss_fight"
  },
  {
    cmd = "frd_boss_static",
    cmd_group = 23,
    cmd_type = 4,
    cmd_name = "EVENT_CMD_23_4",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_frd_boss_static",
    rsp_name = "pbrsp_frd_boss_static"
  },
  {
    cmd = "frd_boss_rank",
    cmd_group = 23,
    cmd_type = 5,
    cmd_name = "EVENT_CMD_23_5",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_frd_boss_rank",
    rsp_name = "pbrsp_frd_boss_rank"
  },
  {
    cmd = "fboss_notify",
    cmd_group = 23,
    cmd_type = 6,
    cmd_name = "EVENT_CMD_23_6",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_fboss_notify",
    rsp_name = "pbrsp_fboss_notify"
  },
  {
    cmd = "fboss_batch",
    cmd_group = 23,
    cmd_type = 7,
    cmd_name = "EVENT_CMD_23_7",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_fboss_batch",
    rsp_name = "pbrsp_fboss_batch"
  },
  {
    cmd = "town_sync",
    cmd_group = 23,
    cmd_type = 8,
    cmd_name = "EVENT_CMD_23_8",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_town_sync",
    rsp_name = "pbrsp_town_sync"
  },
  {
    cmd = "town_reg",
    cmd_group = 23,
    cmd_type = 9,
    cmd_name = "EVENT_CMD_23_9",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_town_reg",
    rsp_name = "pbrsp_town_reg"
  },
  {
    cmd = "town_claim",
    cmd_group = 23,
    cmd_type = 10,
    cmd_name = "EVENT_CMD_23_10",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_town_claim",
    rsp_name = "pbrsp_town_claim"
  },
  {
    cmd = "merge_treasure",
    cmd_group = 6,
    cmd_type = 3,
    cmd_name = "EVENT_CMD_6_3",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_merge_treasure",
    rsp_name = "pbrsp_merge_treasure"
  },
  {
    cmd = "guild_fight_sync",
    cmd_group = 24,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_24_1",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gwar_sync",
    rsp_name = "pbrsp_gwar_sync"
  },
  {
    cmd = "guild_fight_camp",
    cmd_group = 24,
    cmd_type = 2,
    cmd_name = "EVENT_CMD_24_2",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gwcamp",
    rsp_name = "pbrsp_gwcamp"
  },
  {
    cmd = "guild_fight_lineup",
    cmd_group = 24,
    cmd_type = 3,
    cmd_name = "EVENT_CMD_24_3",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gwlineup",
    rsp_name = "pbrsp_gwlineup"
  },
  {
    cmd = "guild_fight_reg",
    cmd_group = 24,
    cmd_type = 4,
    cmd_name = "EVENT_CMD_24_4",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gwreg",
    rsp_name = "pbrsp_gwreg"
  },
  {
    cmd = "guild_fight_rank",
    cmd_group = 24,
    cmd_type = 5,
    cmd_name = "EVENT_CMD_24_5",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gwrank",
    rsp_name = "pbrsp_gwrank"
  },
  {
    cmd = "guild_fight_logs",
    cmd_group = 24,
    cmd_type = 6,
    cmd_name = "EVENT_CMD_24_6",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gwlogs",
    rsp_name = "pbrsp_gwlogs"
  },
  {
    cmd = "guild_fight_log",
    cmd_group = 24,
    cmd_type = 7,
    cmd_name = "EVENT_CMD_24_7",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gwlog",
    rsp_name = "pbrsp_gwlog"
  },
  {
    cmd = "guild_fight_video",
    cmd_group = 24,
    cmd_type = 8,
    cmd_name = "EVENT_CMD_24_8",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gwvideo",
    rsp_name = "pbrsp_gwvideo"
  },
  {
    cmd = "guild_fight_sync_2",
    cmd_group = 24,
    cmd_type = 9,
    cmd_name = "EVENT_CMD_24_9",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gwsync2",
    rsp_name = "pbrsp_gwsync2"
  },
  {
    cmd = "guild_fight_macth",
    cmd_group = 24,
    cmd_type = 10,
    cmd_name = "EVENT_CMD_24_10",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gwmatch",
    rsp_name = "pbrsp_gwmatch"
  },
  {
    cmd = "guild_fight_fight",
    cmd_group = 24,
    cmd_type = 11,
    cmd_name = "EVENT_CMD_24_11",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gwfight",
    rsp_name = "pbrsp_gwfight"
  },
  {
    cmd = "ngw_sync",
    cmd_group = 24,
    cmd_type = 12,
    cmd_name = "EVENT_CMD_24_12",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_ngw_sync",
    rsp_name = "pbrsp_ngw_sync"
  },
  {
    cmd = "ngw_rank",
    cmd_group = 24,
    cmd_type = 13,
    cmd_name = "EVENT_CMD_24_13",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_ngw_rank",
    rsp_name = "pbrsp_ngw_rank"
  },
  {
    cmd = "ngw_camp",
    cmd_group = 24,
    cmd_type = 14,
    cmd_name = "EVENT_CMD_24_14",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_ngw_camp",
    rsp_name = "pbrsp_ngw_camp"
  },
  {
    cmd = "ngw_shold",
    cmd_group = 24,
    cmd_type = 15,
    cmd_name = "EVENT_CMD_24_15",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_ngw_shold",
    rsp_name = "pbrsp_ngw_shold"
  },
  {
    cmd = "ngw_fight",
    cmd_group = 24,
    cmd_type = 16,
    cmd_name = "EVENT_CMD_24_16",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_ngw_fight",
    rsp_name = "pbrsp_ngw_fight"
  },
  {
    cmd = "ngw_lup",
    cmd_group = 24,
    cmd_type = 18,
    cmd_name = "EVENT_CMD_24_18",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_ngw_lup",
    rsp_name = "pbrsp_ngw_lup"
  },
  {
    cmd = "ngw_setup",
    cmd_group = 24,
    cmd_type = 19,
    cmd_name = "EVENT_CMD_24_19",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_ngw_setup",
    rsp_name = "pbrsp_ngw_setup"
  },
  {
    cmd = "ngw_buy",
    cmd_group = 24,
    cmd_type = 21,
    cmd_name = "EVENT_CMD_24_21",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_ngw_buy",
    rsp_name = "pbrsp_ngw_buy"
  },
  {
    cmd = "ngw_info",
    cmd_group = 24,
    cmd_type = 22,
    cmd_name = "EVENT_CMD_24_22",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_ngw_info",
    rsp_name = "pbrsp_ngw_info"
  },
  {
    cmd = "ngw_video",
    cmd_group = 24,
    cmd_type = 23,
    cmd_name = "EVENT_CMD_24_23",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_ngw_video",
    rsp_name = "pbrsp_ngw_video"
  },
  {
    cmd = "ngw_sweep",
    cmd_group = 24,
    cmd_type = 24,
    cmd_name = "EVENT_CMD_24_24",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_ngw_sweep",
    rsp_name = "pbrsp_ngw_sweep"
  },
  {
    cmd = "cgw_sync",
    cmd_group = 24,
    cmd_type = 30,
    cmd_name = "EVENT_CMD_24_30",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_cgw_sync",
    rsp_name = "pbrsp_cgw_sync"
  },
  {
    cmd = "cgw_team",
    cmd_group = 24,
    cmd_type = 31,
    cmd_name = "EVENT_CMD_24_31",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_cgw_team",
    rsp_name = "pbrsp_cgw_team"
  },
  {
    cmd = "cgw_reg",
    cmd_group = 24,
    cmd_type = 32,
    cmd_name = "EVENT_CMD_24_32",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_cgw_reg",
    rsp_name = "pbrsp_cgw_reg"
  },
  {
    cmd = "cgw_honor",
    cmd_group = 24,
    cmd_type = 33,
    cmd_name = "EVENT_CMD_24_33",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_cgw_honor",
    rsp_name = "pbrsp_cgw_honor"
  },
  {
    cmd = "cgw_record",
    cmd_group = 24,
    cmd_type = 34,
    cmd_name = "EVENT_CMD_24_34",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_cgw_record",
    rsp_name = "pbrsp_cgw_record"
  },
  {
    cmd = "cgw_race",
    cmd_group = 24,
    cmd_type = 35,
    cmd_name = "EVENT_CMD_24_35",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_cgw_race",
    rsp_name = "pbrsp_cgw_race"
  },
  {
    cmd = "cgw_log",
    cmd_group = 24,
    cmd_type = 36,
    cmd_name = "EVENT_CMD_24_36",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_cgw_log",
    rsp_name = "pbrsp_cgw_log"
  },
  {
    cmd = "gpvp_sync",
    cmd_group = 26,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_26_1",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gpvp_sync",
    rsp_name = "pbrsp_gpvp_sync"
  },
  {
    cmd = "gpvp_set_camp",
    cmd_group = 26,
    cmd_type = 2,
    cmd_name = "EVENT_CMD_26_2",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gpvp_set_camp",
    rsp_name = "pbrsp_gpvp_set_camp"
  },
  {
    cmd = "create_gpvpteam",
    cmd_group = 26,
    cmd_type = 3,
    cmd_name = "EVENT_CMD_26_3",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_create_gpvpteam",
    rsp_name = "pbrsp_create_gpvpteam"
  },
  {
    cmd = "dismiss_gpvpteam",
    cmd_group = 26,
    cmd_type = 4,
    cmd_name = "EVENT_CMD_26_4",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_dismiss_gpvpteam",
    rsp_name = "pbrsp_dismiss_gpvpteam"
  },
  {
    cmd = "gpvp_match",
    cmd_group = 26,
    cmd_type = 5,
    cmd_name = "EVENT_CMD_26_5",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gpvp_match",
    rsp_name = "pbrsp_gpvp_match"
  },
  {
    cmd = "submit_gpvpteam",
    cmd_group = 26,
    cmd_type = 7,
    cmd_name = "EVENT_CMD_26_7",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_submit_gpvpteam",
    rsp_name = "pbrsp_submit_gpvpteam"
  },
  {
    cmd = "gpvp_leaderop",
    cmd_group = 26,
    cmd_type = 8,
    cmd_name = "EVENT_CMD_26_8",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gpvp_leaderop",
    rsp_name = "pbrsp_gpvp_leaderop"
  },
  {
    cmd = "gpvp_friendslist",
    cmd_group = 26,
    cmd_type = 9,
    cmd_name = "EVENT_CMD_26_9",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gpvp_friendslist",
    rsp_name = "pbrsp_gpvp_friendslist"
  },
  {
    cmd = "gpvpteam_notify",
    cmd_group = 26,
    cmd_type = 10,
    cmd_name = "EVENT_CMD_26_10",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gpvpteam_notify",
    rsp_name = "pbrsp_gpvpteam_notify"
  },
  {
    cmd = "gpvp_invitelist",
    cmd_group = 26,
    cmd_type = 11,
    cmd_name = "EVENT_CMD_26_11",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gpvp_invitelist",
    rsp_name = "pbrsp_gpvp_invitelist"
  },
  {
    cmd = "gpvp_refresh",
    cmd_group = 26,
    cmd_type = 12,
    cmd_name = "EVENT_CMD_26_12",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gpvp_refresh",
    rsp_name = "pbrsp_gpvp_refresh"
  },
  {
    cmd = "gpvp_mbrop",
    cmd_group = 26,
    cmd_type = 13,
    cmd_name = "EVENT_CMD_26_13",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gpvp_mbrop",
    rsp_name = "pbrsp_gpvp_mbrop"
  },
  {
    cmd = "gpvp_ranklist",
    cmd_group = 26,
    cmd_type = 14,
    cmd_name = "EVENT_CMD_26_14",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gpvp_ranklist",
    rsp_name = "pbrsp_gpvp_ranklist"
  },
  {
    cmd = "change_gpvpteam",
    cmd_group = 26,
    cmd_type = 15,
    cmd_name = "EVENT_CMD_26_15",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_change_gpvpteam",
    rsp_name = "pbrsp_change_gpvpteam"
  },
  {
    cmd = "gpvp_applylist",
    cmd_group = 26,
    cmd_type = 16,
    cmd_name = "EVENT_CMD_26_16",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gpvp_applylist",
    rsp_name = "pbrsp_gpvp_applylist"
  },
  {
    cmd = "gpvp_mbr",
    cmd_group = 26,
    cmd_type = 17,
    cmd_name = "EVENT_CMD_26_17",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gpvp_mbr",
    rsp_name = "pbrsp_gpvp_mbr"
  },
  {
    cmd = "gpvp_grp",
    cmd_group = 26,
    cmd_type = 18,
    cmd_name = "EVENT_CMD_26_18",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gpvp_grp",
    rsp_name = "pbrsp_gpvp_grp"
  },
  {
    cmd = "gpvp_fight",
    cmd_group = 26,
    cmd_type = 19,
    cmd_name = "EVENT_CMD_26_19",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gpvp_fight",
    rsp_name = "pbrsp_gpvp_fight"
  },
  {
    cmd = "gpvp_logs",
    cmd_group = 26,
    cmd_type = 20,
    cmd_name = "EVENT_CMD_26_20",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gpvp_logs",
    rsp_name = "pbrsp_gpvp_logs"
  },
  {
    cmd = "gpvp_wlog",
    cmd_group = 26,
    cmd_type = 21,
    cmd_name = "EVENT_CMD_26_21",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gpvp_wlog",
    rsp_name = "pbrsp_gpvp_wlog"
  },
  {
    cmd = "gpvp_video",
    cmd_group = 26,
    cmd_type = 22,
    cmd_name = "EVENT_CMD_26_22",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gpvp_video",
    rsp_name = "pbrsp_gpvp_video"
  },
  {
    cmd = "pet_op",
    cmd_group = 27,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_27_1",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_pet_op",
    rsp_name = "pbrsp_pet_op"
  },
  {
    cmd = "bboss_buy",
    cmd_group = 29,
    cmd_type = 2,
    cmd_name = "EVENT_CMD_29_2",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_bboss_buy",
    rsp_name = "pbrsp_bboss_buy"
  },
  {
    cmd = "bboss_syn",
    cmd_group = 29,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_29_1",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_bboss_syn",
    rsp_name = "pbrsp_bboss_syn"
  },
  {
    cmd = "bboss_fight",
    cmd_group = 29,
    cmd_type = 3,
    cmd_name = "EVENT_CMD_29_3",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_bboss_fight",
    rsp_name = "pbrsp_bboss_fight"
  },
  {
    cmd = "bboss_batch",
    cmd_group = 29,
    cmd_type = 4,
    cmd_name = "EVENT_CMD_29_4",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_bboss_batch",
    rsp_name = "pbrsp_bboss_batch"
  },
  {
    cmd = "spk_sync",
    cmd_group = 28,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_28_1",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_spk_sync",
    rsp_name = "pbrsp_spk_sync"
  },
  {
    cmd = "spk_camp",
    cmd_group = 28,
    cmd_type = 2,
    cmd_name = "EVENT_CMD_28_2",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_spk_camp",
    rsp_name = "pbrsp_spk_camp"
  },
  {
    cmd = "spk_fight",
    cmd_group = 28,
    cmd_type = 3,
    cmd_name = "EVENT_CMD_28_3",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_spk_fight",
    rsp_name = "pbrsp_spk_fight"
  },
  {
    cmd = "spk_buf",
    cmd_group = 28,
    cmd_type = 4,
    cmd_name = "EVENT_CMD_28_4",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_spk_buf",
    rsp_name = "pbrsp_spk_buf"
  },
  {
    cmd = "spk_rank",
    cmd_group = 28,
    cmd_type = 5,
    cmd_name = "EVENT_CMD_28_5",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_spk_rank",
    rsp_name = "pbrsp_spk_rank"
  },
  {
    cmd = "spk_buy",
    cmd_group = 28,
    cmd_type = 6,
    cmd_name = "EVENT_CMD_28_6",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_spk_buy",
    rsp_name = "pbrsp_spk_buy"
  },
  {
    cmd = "island_sync",
    cmd_group = 30,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_30_1",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_island_sync",
    rsp_name = "pbrsp_island_sync"
  },
  {
    cmd = "island_tower",
    cmd_group = 30,
    cmd_type = 2,
    cmd_name = "EVENT_CMD_30_2",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_island_tower",
    rsp_name = "pbrsp_island_tower"
  },
  {
    cmd = "island_op",
    cmd_group = 30,
    cmd_type = 3,
    cmd_name = "EVENT_CMD_30_3",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_island_op",
    rsp_name = "pbrsp_island_op"
  },
  {
    cmd = "island_land",
    cmd_group = 30,
    cmd_type = 4,
    cmd_name = "EVENT_CMD_30_4",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_island_land",
    rsp_name = "pbrsp_island_land"
  },
  {
    cmd = "island_box",
    cmd_group = 30,
    cmd_type = 5,
    cmd_name = "EVENT_CMD_30_5",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_island_box",
    rsp_name = "pbrsp_island_box"
  },
  {
    cmd = "island_npc",
    cmd_group = 30,
    cmd_type = 6,
    cmd_name = "EVENT_CMD_30_6",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_island_npc",
    rsp_name = "pbrsp_island_npc"
  },
  {
    cmd = "island_boss",
    cmd_group = 30,
    cmd_type = 7,
    cmd_name = "EVENT_CMD_30_7",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_island_boss",
    rsp_name = "pbrsp_island_boss"
  },
  {
    cmd = "island_fight",
    cmd_group = 30,
    cmd_type = 8,
    cmd_name = "EVENT_CMD_30_8",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_island_fight",
    rsp_name = "pbrsp_island_fight"
  },
  {
    cmd = "island_buy",
    cmd_group = 30,
    cmd_type = 9,
    cmd_name = "EVENT_CMD_30_9",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_island_buy",
    rsp_name = "pbrsp_island_buy"
  },
  {
    cmd = "island_batch",
    cmd_group = 30,
    cmd_type = 10,
    cmd_name = "EVENT_CMD_30_10",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_island_batch",
    rsp_name = "pbrsp_island_batch"
  },
  {
    cmd = "island_sweep",
    cmd_group = 30,
    cmd_type = 11,
    cmd_name = "EVENT_CMD_30_11",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_island_sweep",
    rsp_name = "pbrsp_island_sweep"
  },
  {
    cmd = "island_bget",
    cmd_group = 30,
    cmd_type = 12,
    cmd_name = "EVENT_CMD_30_12",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_island_bget",
    rsp_name = "pbrsp_island_bget"
  },
  {
    cmd = "island_iboat_sync",
    cmd_group = 30,
    cmd_type = 13,
    cmd_name = "EVENT_CMD_30_13",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_iboat_sync",
    rsp_name = "pbrsp_iboat_sync"
  },
  {
    cmd = "island_iboat_start",
    cmd_group = 30,
    cmd_type = 14,
    cmd_name = "EVENT_CMD_30_14",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_iboat_start",
    rsp_name = "pbrsp_iboat_start"
  },
  {
    cmd = "island_iboat_xp",
    cmd_group = 30,
    cmd_type = 15,
    cmd_name = "EVENT_CMD_30_15",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_iboat_xp",
    rsp_name = "pbrsp_iboat_xp"
  },
  {
    cmd = "island_iboat_xpop",
    cmd_group = 30,
    cmd_type = 16,
    cmd_name = "EVENT_CMD_30_16",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_iboat_xpop",
    rsp_name = "pbrsp_iboat_xpop"
  },
  {
    cmd = "island_iboat_shop",
    cmd_group = 30,
    cmd_type = 17,
    cmd_name = "EVENT_CMD_30_17",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_iboat_shop",
    rsp_name = "pbrsp_iboat_shop"
  },
  {
    cmd = "island_iboat_buy",
    cmd_group = 30,
    cmd_type = 18,
    cmd_name = "EVENT_CMD_30_18",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_iboat_buy",
    rsp_name = "pbrsp_iboat_buy"
  },
  {
    cmd = "island_iboat_arm",
    cmd_group = 30,
    cmd_type = 19,
    cmd_name = "EVENT_CMD_30_19",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_iboat_arm",
    rsp_name = "pbrsp_iboat_arm"
  },
  {
    cmd = "island_iboat_skl",
    cmd_group = 30,
    cmd_type = 20,
    cmd_name = "EVENT_CMD_30_20",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_iboat_skl",
    rsp_name = "pbrsp_iboat_skl"
  },
  {
    cmd = "island_iboat_name",
    cmd_group = 30,
    cmd_type = 21,
    cmd_name = "EVENT_CMD_30_21",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_iboat_name",
    rsp_name = "pbrsp_iboat_name"
  },
  {
    cmd = "island_iboat_fsync",
    cmd_group = 30,
    cmd_type = 22,
    cmd_name = "EVENT_CMD_30_22",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_iboat_fsync",
    rsp_name = "pbrsp_iboat_fsync"
  },
  {
    cmd = "island_iboat_fpro",
    cmd_group = 30,
    cmd_type = 23,
    cmd_name = "EVENT_CMD_30_23",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_iboat_fpro",
    rsp_name = "pbrsp_iboat_fpro"
  },
  {
    cmd = "island_iboat_use",
    cmd_group = 30,
    cmd_type = 24,
    cmd_name = "EVENT_CMD_30_24",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_iboat_use",
    rsp_name = "pbrsp_iboat_use"
  },
  {
    cmd = "beat_nien",
    cmd_group = 31,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_31_1",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_beat_nien",
    rsp_name = "pbrsp_beat_nien"
  },
  {
    cmd = "idcard_verify",
    cmd_group = 32,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_32_1",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_verify_identity",
    rsp_name = "pbrsp_verify_identity"
  },
  {
    cmd = "sealland_sync",
    cmd_group = 9,
    cmd_type = 16,
    cmd_name = "EVENT_CMD_9_16",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_sealand_sync",
    rsp_name = "pbrsp_sealand_sync"
  },
  {
    cmd = "sealland_challenge_buy",
    cmd_group = 9,
    cmd_type = 17,
    cmd_name = "EVENT_CMD_9_17",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_sealand_challenge_buy",
    rsp_name = "pbrsp_sealand_challenge_buy"
  },
  {
    cmd = "sealland_fight",
    cmd_group = 9,
    cmd_type = 18,
    cmd_name = "EVENT_CMD_9_18",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_sealand_fight",
    rsp_name = "pbrsp_sealand_fight"
  },
  {
    cmd = "sealland_reward",
    cmd_group = 9,
    cmd_type = 19,
    cmd_name = "EVENT_CMD_9_19",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_sealand_reward",
    rsp_name = "pbrsp_sealand_reward"
  },
  {
    cmd = "sealland_sweep_buy",
    cmd_group = 9,
    cmd_type = 20,
    cmd_name = "EVENT_CMD_9_20",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_sealand_sweep_buy",
    rsp_name = "pbrsp_sealand_sweep_buy"
  },
  {
    cmd = "sealland_market_buy",
    cmd_group = 9,
    cmd_type = 21,
    cmd_name = "EVENT_CMD_9_21",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_sealand_market_buy",
    rsp_name = "pbrsp_sealand_market_buy"
  },
  {
    cmd = "brave_sweep",
    cmd_group = 9,
    cmd_type = 22,
    cmd_name = "EVENT_CMD_9_22",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_brave_sweep",
    rsp_name = "pbrsp_brave_sweep"
  },
  {
    cmd = "dare_sweep",
    cmd_group = 9,
    cmd_type = 23,
    cmd_name = "EVENT_CMD_9_23",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_dare_sweep",
    rsp_name = "pbrsp_dare_sweep"
  },
  {
    cmd = "monthmarket_buy",
    cmd_group = 33,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_33_1",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_monthmarket_buy",
    rsp_name = "pbrsp_monthmarket_buy"
  },
  {
    cmd = "monthmarket_sync",
    cmd_group = 33,
    cmd_type = 2,
    cmd_name = "EVENT_CMD_33_2",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_monthmarket_sync",
    rsp_name = "pbrsp_monthmarket_sync"
  },
  {
    cmd = "activity",
    cmd_group = 31,
    cmd_type = 2,
    cmd_name = "EVENT_CMD_31_2",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_activity",
    rsp_name = "pbrsp_activity"
  },
  {
    cmd = "activity_sign",
    cmd_group = 31,
    cmd_type = 3,
    cmd_name = "EVENT_CMD_31_3",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_activity_sign",
    rsp_name = "pbrsp_activity_sign"
  },
  {
    cmd = "activity_grid",
    cmd_group = 31,
    cmd_type = 4,
    cmd_name = "EVENT_CMD_31_4",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_activity_grid",
    rsp_name = "pbrsp_activity_grid"
  },
  {
    cmd = "activity_skim",
    cmd_group = 31,
    cmd_type = 5,
    cmd_name = "EVENT_CMD_31_5",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_activity_skim",
    rsp_name = "pbrsp_activity_skim"
  },
  {
    cmd = "maze_open",
    cmd_group = 31,
    cmd_type = 20,
    cmd_name = "EVENT_CMD_31_20",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_maze_open",
    rsp_name = "pbrsp_maze_open"
  },
  {
    cmd = "maze_change_hero",
    cmd_group = 31,
    cmd_type = 21,
    cmd_name = "EVENT_CMD_31_21",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_maze_change_hero",
    rsp_name = "pbrsp_maze_change_hero"
  },
  {
    cmd = "maze_open2",
    cmd_group = 31,
    cmd_type = 22,
    cmd_name = "EVENT_CMD_31_22",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_maze_open2",
    rsp_name = "pbrsp_maze_open2"
  },
  {
    cmd = "maze_buy",
    cmd_group = 31,
    cmd_type = 23,
    cmd_name = "EVENT_CMD_31_23",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_maze_buy",
    rsp_name = "pbrsp_maze_buy"
  },
  {
    cmd = "maze_sync",
    cmd_group = 31,
    cmd_type = 24,
    cmd_name = "EVENT_CMD_31_24",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_maze_sync",
    rsp_name = "pbrsp_maze_sync"
  },
  {
    cmd = "maze_break",
    cmd_group = 31,
    cmd_type = 25,
    cmd_name = "EVENT_CMD_31_25",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_maze_break",
    rsp_name = "pbrsp_maze_break"
  },
  {
    cmd = "fetch_sact",
    cmd_group = 31,
    cmd_type = 26,
    cmd_name = "EVENT_CMD_31_26",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_fetch_sact",
    rsp_name = "pbrsp_fetch_sact"
  },
  {
    cmd = "sact_summer_buy",
    cmd_group = 36,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_36_1",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_sact_summer_buy",
    rsp_name = "pbrsp_sact_summer_buy"
  },
  {
    cmd = "sact_gache",
    cmd_group = 36,
    cmd_type = 2,
    cmd_name = "EVENT_CMD_36_2",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_sact_gache",
    rsp_name = "pbrsp_sact_gache"
  },
  {
    cmd = "sact_five_year_exchange",
    cmd_group = 36,
    cmd_type = 3,
    cmd_name = "EVENT_CMD_36_3",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_sact_five_year_exchange",
    rsp_name = "pbrsp_sact_five_year_exchange"
  },
  {
    cmd = "sact_five_year_exchange_buy",
    cmd_group = 36,
    cmd_type = 4,
    cmd_name = "EVENT_CMD_36_4",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_sact_five_year_exchange_buy",
    rsp_name = "pbrsp_sact_five_year_exchange_buy"
  },
  {
    cmd = "sact_five_year_boat",
    cmd_group = 36,
    cmd_type = 5,
    cmd_name = "EVENT_CMD_36_5",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_sact_five_year_boat",
    rsp_name = "pbrsp_sact_five_year_boat"
  },
  {
    cmd = "five_year_wish",
    cmd_group = 36,
    cmd_type = 6,
    cmd_name = "EVENT_CMD_36_6",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_sact_five_year_wish",
    rsp_name = "pbrsp_sact_five_year_wish"
  },
  {
    cmd = "five_year_open_box",
    cmd_group = 36,
    cmd_type = 7,
    cmd_name = "EVENT_CMD_36_7",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_sact_five_year_open_box",
    rsp_name = "pbrsp_sact_five_year_open_box"
  },
  {
    cmd = "hero_log",
    cmd_group = 37,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_37_1",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_hero_log",
    rsp_name = "pbrsp_hero_log"
  },
  {
    cmd = "brave_open",
    cmd_group = 38,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_38_1",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_brave_open",
    rsp_name = "pbrsp_brave_open"
  },
  {
    cmd = "brave_altar",
    cmd_group = 38,
    cmd_type = 2,
    cmd_name = "EVENT_CMD_38_2",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_brave_altar",
    rsp_name = "pbrsp_brave_altar"
  },
  {
    cmd = "brave_buy",
    cmd_group = 38,
    cmd_type = 3,
    cmd_name = "EVENT_CMD_38_3",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_brave_buy",
    rsp_name = "pbrsp_brave_buy"
  },
  {
    cmd = "jp_step",
    cmd_group = 38,
    cmd_type = 4,
    cmd_name = "EVENT_CMD_38_4",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_jp_step",
    rsp_name = "pbrsp_jp_step"
  },
  {
    cmd = "sact_login",
    cmd_group = 38,
    cmd_type = 5,
    cmd_name = "EVENT_CMD_38_5",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_sact_login",
    rsp_name = "pbrsp_sact_login"
  },
  {
    cmd = "wpvp_sync",
    cmd_group = 39,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_39_1",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_wsync",
    rsp_name = "pbrsp_wsync"
  },
  {
    cmd = "wpvp_honor",
    cmd_group = 39,
    cmd_type = 2,
    cmd_name = "EVENT_CMD_39_2",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_whonor",
    rsp_name = "pbrsp_whonor"
  },
  {
    cmd = "wpvp_daily",
    cmd_group = 39,
    cmd_type = 3,
    cmd_name = "EVENT_CMD_39_3",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_wdaily",
    rsp_name = "pbrsp_wdaily"
  },
  {
    cmd = "wpvp_match",
    cmd_group = 39,
    cmd_type = 4,
    cmd_name = "EVENT_CMD_39_4",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_wmatch",
    rsp_name = "pbrsp_wmatch"
  },
  {
    cmd = "wpvp_camp",
    cmd_group = 39,
    cmd_type = 5,
    cmd_name = "EVENT_CMD_39_5",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_wcamp",
    rsp_name = "pbrsp_wcamp"
  },
  {
    cmd = "wpvp_fight",
    cmd_group = 39,
    cmd_type = 6,
    cmd_name = "EVENT_CMD_39_6",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_wfight",
    rsp_name = "pbrsp_wfight"
  },
  {
    cmd = "wpvp_like",
    cmd_group = 39,
    cmd_type = 7,
    cmd_name = "EVENT_CMD_39_7",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_wlike",
    rsp_name = "pbrsp_wlike"
  },
  {
    cmd = "wpvp_info",
    cmd_group = 39,
    cmd_type = 8,
    cmd_name = "EVENT_CMD_39_8",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_winfo",
    rsp_name = "pbrsp_winfo"
  },
  {
    cmd = "wpvp_zone",
    cmd_group = 39,
    cmd_type = 9,
    cmd_name = "EVENT_CMD_39_9",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_wzone",
    rsp_name = "pbrsp_wzone"
  },
  {
    cmd = "wpvp_loger1",
    cmd_group = 39,
    cmd_type = 10,
    cmd_name = "EVENT_CMD_39_10",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_wloger1",
    rsp_name = "pbrsp_wloger1"
  },
  {
    cmd = "wpvp_log1",
    cmd_group = 39,
    cmd_type = 11,
    cmd_name = "EVENT_CMD_39_11",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_wlog1",
    rsp_name = "pbrsp_wlog1"
  },
  {
    cmd = "wpvp_video1",
    cmd_group = 39,
    cmd_type = 12,
    cmd_name = "EVENT_CMD_39_12",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_wvideo1",
    rsp_name = "pbrsp_wvideo1"
  },
  {
    cmd = "wpvp_log2",
    cmd_group = 39,
    cmd_type = 13,
    cmd_name = "EVENT_CMD_39_13",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_wlog2",
    rsp_name = "pbrsp_wlog2"
  },
  {
    cmd = "wpvp_video2",
    cmd_group = 39,
    cmd_type = 14,
    cmd_name = "EVENT_CMD_39_14",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_wvideo2",
    rsp_name = "pbrsp_wvideo2"
  },
  {
    cmd = "tutorial",
    cmd_group = 40,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_40_1",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_tutorial",
    rsp_name = "pbrsp_tutorial"
  },
  {
    cmd = "ract_receive",
    cmd_group = 41,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_41_1",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_ract_receive",
    rsp_name = "pbrsp_ract_receive"
  },
  {
    cmd = "ract_power",
    cmd_group = 41,
    cmd_type = 2,
    cmd_name = "EVENT_CMD_41_2",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_ract_power",
    rsp_name = "pbrsp_ract_power"
  },
  {
    cmd = "task_convert",
    cmd_group = 20,
    cmd_type = 4,
    cmd_name = "EVENT_CMD_20_4",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_task_convert",
    rsp_name = "pbrsp_task_convert"
  },
  {
    cmd = "fetch_activity",
    cmd_group = 31,
    cmd_type = 6,
    cmd_name = "EVENT_CMD_31_6",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_fetch_activity",
    rsp_name = "pbrsp_fetch_activity"
  },
  {
    cmd = "reset_casino",
    cmd_group = 31,
    cmd_type = 7,
    cmd_name = "EVENT_CMD_31_7",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_reset_casino",
    rsp_name = "pbrsp_reset_casino"
  },
  {
    cmd = "monopoly_dice",
    cmd_group = 31,
    cmd_type = 10,
    cmd_name = "EVENT_CMD_31_10",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_monopoly_dice",
    rsp_name = "pbrsp_monopoly_dice"
  },
  {
    cmd = "buy_dice",
    cmd_group = 31,
    cmd_type = 11,
    cmd_name = "EVENT_CMD_31_11",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_buy_dice",
    rsp_name = "pbrsp_buy_dice"
  },
  {
    cmd = "youtuber_refresh",
    cmd_group = 31,
    cmd_type = 14,
    cmd_name = "EVENT_CMD_31_14",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_youtuber_refresh",
    rsp_name = "pbrsp_youtuber_refresh"
  },
  {
    cmd = "forge_back",
    cmd_group = 31,
    cmd_type = 15,
    cmd_name = "EVENT_CMD_31_15",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_forge_back",
    rsp_name = "pbrsp_forge_back"
  },
  {
    cmd = "gold_card",
    cmd_group = 31,
    cmd_type = 16,
    cmd_name = "EVENT_CMD_31_16",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_gold_card",
    rsp_name = "pbrsp_gold_card"
  },
  {
    cmd = "chick",
    cmd_group = 31,
    cmd_type = 17,
    cmd_name = "EVENT_CMD_31_17",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_chick",
    rsp_name = "pbrsp_chick"
  },
  {
    cmd = "limit_gift_activate",
    cmd_group = 31,
    cmd_type = 18,
    cmd_name = "EVENT_CMD_31_18",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_limit_gift_activate",
    rsp_name = "pbrsp_limit_gift_activate"
  },
  {
    cmd = "follow",
    cmd_group = 31,
    cmd_type = 19,
    cmd_name = "EVENT_CMD_31_19",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_follow",
    rsp_name = "pbrsp_follow"
  },
  {
    cmd = "htask_commit",
    cmd_group = 31,
    cmd_type = 30,
    cmd_name = "EVENT_CMD_31_30",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_htask_commit",
    rsp_name = "pbrsp_htask_commit"
  },
  {
    cmd = "re_sync",
    cmd_group = 34,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_34_1",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_re_sync",
    rsp_name = "pbrsp_re_sync"
  },
  {
    cmd = "re_code",
    cmd_group = 34,
    cmd_type = 2,
    cmd_name = "EVENT_CMD_34_2",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_re_code",
    rsp_name = "pbrsp_re_code"
  },
  {
    cmd = "re_bind",
    cmd_group = 34,
    cmd_type = 3,
    cmd_name = "EVENT_CMD_34_3",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_re_bind",
    rsp_name = "pbrsp_re_bind"
  },
  {
    cmd = "forge_artifact",
    cmd_group = 31,
    cmd_type = 8,
    cmd_name = "EVENT_CMD_31_8",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_forge_artifact",
    rsp_name = "pbrsp_forge_artifact"
  },
  {
    cmd = "crack_artifact",
    cmd_group = 31,
    cmd_type = 9,
    cmd_name = "EVENT_CMD_31_9",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_crack_artifact",
    rsp_name = "pbrsp_crack_artifact"
  },
  {
    cmd = "hero_forever",
    cmd_group = 31,
    cmd_type = 12,
    cmd_name = "EVENT_CMD_31_12",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_hero_forever",
    rsp_name = "pbrsp_hero_forever"
  },
  {
    cmd = "st_sync",
    cmd_group = 42,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_42_1",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_sync",
    rsp_name = "pbrsp_st_sync"
  },
  {
    cmd = "st_summon",
    cmd_group = 42,
    cmd_type = 2,
    cmd_name = "EVENT_CMD_42_2",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_summon",
    rsp_name = "pbrsp_st_summon"
  },
  {
    cmd = "st_schange",
    cmd_group = 42,
    cmd_type = 3,
    cmd_name = "EVENT_CMD_42_3",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_schange",
    rsp_name = "pbrsp_st_schange"
  },
  {
    cmd = "st_msync",
    cmd_group = 42,
    cmd_type = 4,
    cmd_name = "EVENT_CMD_42_4",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_msync",
    rsp_name = "pbrsp_st_msync"
  },
  {
    cmd = "st_rank",
    cmd_group = 42,
    cmd_type = 5,
    cmd_name = "EVENT_CMD_42_5",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_rank",
    rsp_name = "pbrsp_st_rank"
  },
  {
    cmd = "st_hforge",
    cmd_group = 42,
    cmd_type = 6,
    cmd_name = "EVENT_CMD_42_6",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_hforge",
    rsp_name = "pbrsp_st_hforge"
  },
  {
    cmd = "st_hattrup",
    cmd_group = 42,
    cmd_type = 7,
    cmd_name = "EVENT_CMD_42_7",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_hattrup",
    rsp_name = "pbrsp_st_hattrup"
  },
  {
    cmd = "st_hattrchange",
    cmd_group = 42,
    cmd_type = 8,
    cmd_name = "EVENT_CMD_42_8",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_hattrchange",
    rsp_name = "pbrsp_st_hattrchange"
  },
  {
    cmd = "st_hattractivate",
    cmd_group = 42,
    cmd_type = 9,
    cmd_name = "EVENT_CMD_42_9",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_hattractivate",
    rsp_name = "pbrsp_st_hattractivate"
  },
  {
    cmd = "st_vsync",
    cmd_group = 42,
    cmd_type = 10,
    cmd_name = "EVENT_CMD_42_10",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_vsync",
    rsp_name = "pbrsp_st_vsync"
  },
  {
    cmd = "st_vsync2",
    cmd_group = 42,
    cmd_type = 11,
    cmd_name = "EVENT_CMD_42_11",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_vsync2",
    rsp_name = "pbrsp_st_vsync2"
  },
  {
    cmd = "st_vevent",
    cmd_group = 42,
    cmd_type = 12,
    cmd_name = "EVENT_CMD_42_12",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_vevent",
    rsp_name = "pbrsp_st_vevent"
  },
  {
    cmd = "st_vdiff",
    cmd_group = 42,
    cmd_type = 13,
    cmd_name = "EVENT_CMD_42_13",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_vdiff",
    rsp_name = "pbrsp_st_vdiff"
  },
  {
    cmd = "st_heartresolve",
    cmd_group = 42,
    cmd_type = 14,
    cmd_name = "EVENT_CMD_42_14",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_heartresolve",
    rsp_name = "pbrsp_st_heartresolve"
  },
  {
    cmd = "st_vwipe",
    cmd_group = 42,
    cmd_type = 15,
    cmd_name = "EVENT_CMD_42_15",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_vwipe",
    rsp_name = "pbrsp_st_vwipe"
  },
  {
    cmd = "st_vuseitem",
    cmd_group = 42,
    cmd_type = 16,
    cmd_name = "EVENT_CMD_42_16",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_vuseitem",
    rsp_name = "pbrsp_st_vuseitem"
  },
  {
    cmd = "st_esync",
    cmd_group = 42,
    cmd_type = 17,
    cmd_name = "EVENT_CMD_42_17",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_esync",
    rsp_name = "pbrsp_st_esync"
  },
  {
    cmd = "st_ebuy",
    cmd_group = 42,
    cmd_type = 18,
    cmd_name = "EVENT_CMD_42_18",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_ebuy",
    rsp_name = "pbrsp_st_ebuy"
  },
  {
    cmd = "st_euse",
    cmd_group = 42,
    cmd_type = 19,
    cmd_name = "EVENT_CMD_42_19",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_euse",
    rsp_name = "pbrsp_st_euse"
  },
  {
    cmd = "st_efight",
    cmd_group = 42,
    cmd_type = 20,
    cmd_name = "EVENT_CMD_42_20",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_efight",
    rsp_name = "pbrsp_st_efight"
  },
  {
    cmd = "st_erank1",
    cmd_group = 42,
    cmd_type = 21,
    cmd_name = "EVENT_CMD_42_21",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_erank1",
    rsp_name = "pbrsp_st_erank1"
  },
  {
    cmd = "st_erank2",
    cmd_group = 42,
    cmd_type = 22,
    cmd_name = "EVENT_CMD_42_22",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_erank2",
    rsp_name = "pbrsp_st_erank2"
  },
  {
    cmd = "st_eget",
    cmd_group = 42,
    cmd_type = 23,
    cmd_name = "EVENT_CMD_42_23",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_eget",
    rsp_name = "pbrsp_st_eget"
  },
  {
    cmd = "st_eopen",
    cmd_group = 42,
    cmd_type = 24,
    cmd_name = "EVENT_CMD_42_24",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_eopen",
    rsp_name = "pbrsp_st_eopen"
  },
  {
    cmd = "st_async",
    cmd_group = 42,
    cmd_type = 25,
    cmd_name = "EVENT_CMD_42_25",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_async",
    rsp_name = "pbrsp_st_async"
  },
  {
    cmd = "st_erefresh",
    cmd_group = 42,
    cmd_type = 26,
    cmd_name = "EVENT_CMD_42_26",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_erefresh",
    rsp_name = "pbrsp_st_erefresh"
  },
  {
    cmd = "st_hattrreset",
    cmd_group = 42,
    cmd_type = 27,
    cmd_name = "EVENT_CMD_42_27",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_hattrreset",
    rsp_name = "pbrsp_st_hattrreset"
  },
  {
    cmd = "st_tback",
    cmd_group = 42,
    cmd_type = 28,
    cmd_name = "EVENT_CMD_42_28",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_tback",
    rsp_name = "pbrsp_st_tback"
  },
  {
    cmd = "st_changenight",
    cmd_group = 42,
    cmd_type = 29,
    cmd_name = "EVENT_CMD_42_29",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_changenight",
    rsp_name = "pbrsp_st_changenight"
  },
  {
    cmd = "st_starresolve",
    cmd_group = 42,
    cmd_type = 30,
    cmd_name = "EVENT_CMD_42_30",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_starresolve",
    rsp_name = "pbrsp_st_starresolve"
  },
  {
    cmd = "st_ssync",
    cmd_group = 42,
    cmd_type = 36,
    cmd_name = "EVENT_CMD_42_36",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_ssync",
    rsp_name = "pbrsp_st_ssync"
  },
  {
    cmd = "st_slvup",
    cmd_group = 42,
    cmd_type = 37,
    cmd_name = "EVENT_CMD_42_37",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_slvup",
    rsp_name = "pbrsp_st_slvup"
  },
  {
    cmd = "st_ssweep",
    cmd_group = 42,
    cmd_type = 38,
    cmd_name = "EVENT_CMD_42_38",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_ssweep",
    rsp_name = "pbrsp_st_ssweep"
  },
  {
    cmd = "st_ssklup",
    cmd_group = 42,
    cmd_type = 39,
    cmd_name = "EVENT_CMD_42_39",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_ssklup",
    rsp_name = "pbrsp_st_ssklup"
  },
  {
    cmd = "st_sstore",
    cmd_group = 42,
    cmd_type = 40,
    cmd_name = "EVENT_CMD_42_40",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_sstore",
    rsp_name = "pbrsp_st_sstore"
  },
  {
    cmd = "st_sbuy",
    cmd_group = 42,
    cmd_type = 41,
    cmd_name = "EVENT_CMD_42_41",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_sbuy",
    rsp_name = "pbrsp_st_sbuy"
  },
  {
    cmd = "st_smap_unlock",
    cmd_group = 42,
    cmd_type = 42,
    cmd_name = "EVENT_CMD_42_42",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_smap_unlock",
    rsp_name = "pbrsp_st_smap_unlock"
  },
  {
    cmd = "st_smap_sync",
    cmd_group = 42,
    cmd_type = 43,
    cmd_name = "EVENT_CMD_42_43",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_smap_sync",
    rsp_name = "pbrsp_st_smap_sync"
  },
  {
    cmd = "st_scell_unlock",
    cmd_group = 42,
    cmd_type = 44,
    cmd_name = "EVENT_CMD_42_44",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_scell_unlock",
    rsp_name = "pbrsp_st_scell_unlock"
  },
  {
    cmd = "st_scell_disp",
    cmd_group = 42,
    cmd_type = 45,
    cmd_name = "EVENT_CMD_42_45",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_scell_disp",
    rsp_name = "pbrsp_st_scell_disp"
  },
  {
    cmd = "st_scell_fight",
    cmd_group = 42,
    cmd_type = 46,
    cmd_name = "EVENT_CMD_42_46",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_scell_fight",
    rsp_name = "pbrsp_st_scell_fight"
  },
  {
    cmd = "st_smap_sett",
    cmd_group = 42,
    cmd_type = 47,
    cmd_name = "EVENT_CMD_42_47",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_smap_sett",
    rsp_name = "pbrsp_st_smap_sett"
  },
  {
    cmd = "st_smap_team",
    cmd_group = 42,
    cmd_type = 48,
    cmd_name = "EVENT_CMD_42_48",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_smap_team",
    rsp_name = "pbrsp_st_smap_team"
  },
  {
    cmd = "st_smap_rank",
    cmd_group = 42,
    cmd_type = 49,
    cmd_name = "EVENT_CMD_42_49",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_smap_rank",
    rsp_name = "pbrsp_st_smap_rank"
  },
  {
    cmd = "st_smap_mbr",
    cmd_group = 42,
    cmd_type = 50,
    cmd_name = "EVENT_CMD_42_50",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_smap_mbr",
    rsp_name = "pbrsp_st_smap_mbr"
  },
  {
    cmd = "st_sclick",
    cmd_group = 42,
    cmd_type = 51,
    cmd_name = "EVENT_CMD_42_51",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_sclick",
    rsp_name = "pbrsp_st_sclick"
  },
  {
    cmd = "spet_reset",
    cmd_group = 42,
    cmd_type = 53,
    cmd_name = "EVENT_CMD_42_53",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_spet_reset",
    rsp_name = "pbrsp_spet_reset"
  },
  {
    cmd = "lobi_vote",
    cmd_group = 31,
    cmd_type = 13,
    cmd_name = "EVENT_CMD_31_13",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_youtuber",
    rsp_name = "pbrsp_youtuber"
  },
  {
    cmd = "stower_sync",
    cmd_group = 42,
    cmd_type = 31,
    cmd_name = "EVENT_CMD_42_31",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_stower_sync",
    rsp_name = "pbrsp_stower_sync"
  },
  {
    cmd = "stower_up",
    cmd_group = 42,
    cmd_type = 32,
    cmd_name = "EVENT_CMD_42_32",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_stower_up",
    rsp_name = "pbrsp_stower_up"
  },
  {
    cmd = "stower_hatch",
    cmd_group = 42,
    cmd_type = 33,
    cmd_name = "EVENT_CMD_42_33",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_stower_hatch",
    rsp_name = "pbrsp_stower_hatch"
  },
  {
    cmd = "stower_hover",
    cmd_group = 42,
    cmd_type = 34,
    cmd_name = "EVENT_CMD_42_34",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_stower_hover",
    rsp_name = "pbrsp_stower_hover"
  },
  {
    cmd = "spet_up",
    cmd_group = 42,
    cmd_type = 35,
    cmd_name = "EVENT_CMD_42_35",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_spet_up",
    rsp_name = "pbrsp_spet_up"
  },
  {
    cmd = "st_hchange",
    cmd_group = 42,
    cmd_type = 52,
    cmd_name = "EVENT_CMD_42_52",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_st_hchange",
    rsp_name = "pbrsp_st_hchange"
  },
  {
    cmd = "ntask_sync",
    cmd_group = 43,
    cmd_type = 1,
    cmd_name = "EVENT_CMD_43_1",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_ntask_sync",
    rsp_name = "pbrsp_ntask_sync"
  },
  {
    cmd = "ntask_claim",
    cmd_group = 43,
    cmd_type = 2,
    cmd_name = "EVENT_CMD_43_2",
    module_name = "dr2_logic_pb",
    req_name = "pbreq_ntask_claim",
    rsp_name = "pbrsp_ntask_claim"
  }
}
return eventname