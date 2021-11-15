// ReSharper disable IdentifierTypo
namespace Idle.Emu.Messages 
{
	public enum EPacketEvent 
	{
		IdleEchoRequest = 1010,
		IdleEchoResponse = 1011,

		IdlePubRequest = 1020,
		IdlePubResponse = 1021,

		IdleRegRequest = 2010,
		IdleRegResponse = 2011,

		IdleSaltRequest = 2020,
		IdleSaltResponse = 2021,

		IdleLoginRequest = 2030,
		IdleLoginResponse = 2031,

		IdleThirdloginRequest = 2040,
		IdleThirdloginResponse = 2041,

		IdleServersLoginRequest = 2050,
		IdleServersLoginResponse = 2051,

		IdleAuthRequest = 3010,
		IdleAuthResponse = 3011,

		IdleSyncRequest = 3020,
		IdleSyncResponse = 3021,

		IdleUpRequest = 3030,
		IdleUpResponse = 3031,

		IdleBindRequest = 3040,
		IdleBindResponse = 3041,

		IdleChangePasswordRequest = 3050,
		IdleChangePasswordResponse = 3051,

		IdleServersRequest = 3060,
		IdleServersResponse = 3061,

		IdlePlayerRequest = 3070,
		IdlePlayerResponse = 3071,

		IdleChangeNameRequest = 3080,
		IdleChangeNameResponse = 3081,

		IdleChangeLogoRequest = 3090,
		IdleChangeLogoResponse = 3091,

		IdleRateUsRequest = 30100,
		IdleRateUsResponse = 30101,

		IdleCdkeyRequest = 30130,
		IdleCdkeyResponse = 30131,

		IdleLpubRequest = 30140,
		IdleLpubResponse = 30141,

		IdleChangeBorderRequest = 30150,
		IdleChangeBorderResponse = 30151,

		IdleUpgradeBorderRequest = 30160,
		IdleUpgradeBorderResponse = 30161,

		IdleFlagWebgameRequest = 30170,
		IdleFlagWebgameResponse = 30171,

		IdleSmsgRequest = 30180,
		IdleSmsgResponse = 30181,

		IdleAuditRequest = 30190,
		IdleAuditResponse = 30191,

		IdleGachaRequest = 4010,
		IdleGachaResponse = 4011,

		IdleWearRequest = 4020,
		IdleWearResponse = 4021,

		IdleHeroDecomposeRequest = 4030,
		IdleHeroDecomposeResponse = 4031,

		IdleHeroMergeRequest = 4040,
		IdleHeroMergeResponse = 4041,

		IdleHeroUpRequest = 4050,
		IdleHeroUpResponse = 4051,

		IdleHeroLockRequest = 4060,
		IdleHeroLockResponse = 4061,

		IdleHeroMixRequest = 4070,
		IdleHeroMixResponse = 4071,

		IdleJadeOnRequest = 4080,
		IdleJadeOnResponse = 4081,

		IdleJadeUpRequest = 4090,
		IdleJadeUpResponse = 4091,

		IdleJadeChangeRequest = 40100,
		IdleJadeChangeResponse = 40101,

		IdleJadeOkRequest = 40110,
		IdleJadeOkResponse = 40111,

		IdleBuyHlimitRequest = 40120,
		IdleBuyHlimitResponse = 40121,

		IdleTransformHeroRequest = 40130,
		IdleTransformHeroResponse = 40131,

		IdleTransformOkRequest = 40140,
		IdleTransformOkResponse = 40141,

		IdleHeroWakeRequest = 40150,
		IdleHeroWakeResponse = 40151,

		IdleHeroChangeRequest = 40160,
		IdleHeroChangeResponse = 40161,

		IdleHeroSkinMixRequest = 40170,
		IdleHeroSkinMixResponse = 40171,

		IdleHeroSkinWearRequest = 40180,
		IdleHeroSkinWearResponse = 40181,

		IdleHeroSkinOffRequest = 40190,
		IdleHeroSkinOffResponse = 40191,

		IdleShieldChangeRequest = 40200,
		IdleShieldChangeResponse = 40201,

		IdleHeroSkinVisitRequest = 40210,
		IdleHeroSkinVisitResponse = 40211,

		IdleHeroSkinBreakdownRequest = 40220,
		IdleHeroSkinBreakdownResponse = 40221,

		IdleHeroTalenRequest = 40230,
		IdleHeroTalenResponse = 40231,

		IdleHeroTalenopRequest = 40240,
		IdleHeroTalenopResponse = 40241,

		IdleHeroReturnRequest = 40250,
		IdleHeroReturnResponse = 40251,

		IdleHeroSkinLimitmixRequest = 40260,
		IdleHeroSkinLimitmixResponse = 40261,

		IdleHeroSkinUpRequest = 40270,
		IdleHeroSkinUpResponse = 40271,

		IdleHeroTicketRequest = 40280,
		IdleHeroTicketResponse = 40281,

		IdleJadeUnlockRequest = 40290,
		IdleJadeUnlockResponse = 40291,

		IdleJadeUsedRequest = 40300,
		IdleJadeUsedResponse = 40301,

		IdleAutoLvupRequest = 40310,
		IdleAutoLvupResponse = 40311,

		IdleOpMailRequest = 5010,
		IdleOpMailResponse = 5011,

		IdleSendMailRequest = 5020,
		IdleSendMailResponse = 5021,

		IdleSellRequest = 6010,
		IdleSellResponse = 6011,

		IdleMidasRequest = 6020,
		IdleMidasResponse = 6021,

		IdleUpTreasureRequest = 6040,
		IdleUpTreasureResponse = 6041,

		IdleEquipMergeRequest = 6050,
		IdleEquipMergeResponse = 6051,

		IdleExchangeActRequest = 6060,
		IdleExchangeActResponse = 6061,

		IdleOpenGiftRequest = 6070,
		IdleOpenGiftResponse = 6071,

		IdleDwarfRequest = 6080,
		IdleDwarfResponse = 6081,

		IdleEquipResolveRequest = 6090,
		IdleEquipResolveResponse = 6091,

		IdleEquipSoulRequest = 60100,
		IdleEquipSoulResponse = 60101,

		IdleEquipSoulOkRequest = 60110,
		IdleEquipSoulOkResponse = 60111,

		IdleEquipSoulSyncRequest = 60120,
		IdleEquipSoulSyncResponse = 60121,

		IdleDwarfChangeRequest = 60130,
		IdleDwarfChangeResponse = 60131,

		IdleSyncChatRequest = 7010,
		IdleSyncChatResponse = 7011,

		IdleChatRequest = 7020,
		IdleChatResponse = 7021,

		IdleCunitRequest = 7030,
		IdleCunitResponse = 7031,

		IdleBlockChatRequest = 7040,
		IdleBlockChatResponse = 7041,

		IdleHideVipRequest = 7050,
		IdleHideVipResponse = 7051,

		IdleTranslateRequest = 7060,
		IdleTranslateResponse = 7061,

		IdleChatSettingRequest = 7070,
		IdleChatSettingResponse = 7071,

		IdleResolveBlockChatRequest = 7080,
		IdleResolveBlockChatResponse = 7081,

		IdleGetBlockChatRequest = 7090,
		IdleGetBlockChatResponse = 7091,

		IdleReportRequest = 70120,
		IdleReportResponse = 70121,

		IdleBmarketPullRequest = 8010,
		IdleBmarketPullResponse = 8011,

		IdleBmarketBuyRequest = 8020,
		IdleBmarketBuyResponse = 8021,

		IdleHookInitRequest = 9010,
		IdleHookInitResponse = 9011,

		IdleHookChangeRequest = 9020,
		IdleHookChangeResponse = 9021,

		IdleHookAskRequest = 9030,
		IdleHookAskResponse = 9031,

		IdleHookRewardRequest = 9040,
		IdleHookRewardResponse = 9041,

		IdleTestFightRequest = 9060,
		IdleTestFightResponse = 9061,

		IdlePveRequest = 9070,
		IdlePveResponse = 9071,

		IdleSyncBraveRequest = 90110,
		IdleSyncBraveResponse = 90111,

		IdleBraveFightRequest = 90120,
		IdleBraveFightResponse = 90121,

		IdleBravePullRequest = 90130,
		IdleBravePullResponse = 90131,

		IdleBraveNodeRequest = 90140,
		IdleBraveNodeResponse = 90141,

		IdlePveRankRequest = 90150,
		IdlePveRankResponse = 90151,

		IdleFrdSyncRequest = 10010,
		IdleFrdSyncResponse = 10011,

		IdleFrdOpRequest = 10020,
		IdleFrdOpResponse = 10021,

		IdleFrdLoveRequest = 10030,
		IdleFrdLoveResponse = 10031,

		IdleFrdPkRequest = 10050,
		IdleFrdPkResponse = 10051,

		IdleFrdAdviseRequest = 10060,
		IdleFrdAdviseResponse = 10061,

		IdlePullCasinoRequest = 11010,
		IdlePullCasinoResponse = 11011,

		IdleCasinoMsgRequest = 11020,
		IdleCasinoMsgResponse = 11021,

		IdleCasinoDrawRequest = 11030,
		IdleCasinoDrawResponse = 11031,

		IdleCasinoBuyRequest = 11040,
		IdleCasinoBuyResponse = 11041,

		IdleLmarketPullRequest = 12010,
		IdleLmarketPullResponse = 12011,

		IdleLmarketBuyRequest = 12020,
		IdleLmarketBuyResponse = 12021,

		IdleGuildSyncRequest = 13010,
		IdleGuildSyncResponse = 13011,

		IdleGuildRankRequest = 13020,
		IdleGuildRankResponse = 13021,

		IdleGlogRequest = 13030,
		IdleGlogResponse = 13031,

		IdleGuildCreateRequest = 13040,
		IdleGuildCreateResponse = 13041,

		IdleGuildNoticeRequest = 13050,
		IdleGuildNoticeResponse = 13051,

		IdleGuildFlagRequest = 13060,
		IdleGuildFlagResponse = 13061,

		IdleGuildNameRequest = 13070,
		IdleGuildNameResponse = 13071,

		IdleGuildDismissRequest = 13080,
		IdleGuildDismissResponse = 13081,

		IdleGuildApplyRequest = 13090,
		IdleGuildApplyResponse = 13091,

		IdleGuildLeaveRequest = 130100,
		IdleGuildLeaveResponse = 130101,

		IdleGuildSignRequest = 130110,
		IdleGuildSignResponse = 130111,

		IdleGuildRecommendRequest = 130120,
		IdleGuildRecommendResponse = 130121,

		IdleGuildSearchRequest = 130130,
		IdleGuildSearchResponse = 130131,

		IdleGuildAppliersRequest = 130140,
		IdleGuildAppliersResponse = 130141,

		IdleGmemberOptRequest = 130150,
		IdleGmemberOptResponse = 130151,

		IdleGbossSyncRequest = 130160,
		IdleGbossSyncResponse = 130161,

		IdleGbossRankRequest = 130170,
		IdleGbossRankResponse = 130171,

		IdleGbossFightRequest = 130180,
		IdleGbossFightResponse = 130181,

		IdleGsklSyncRequest = 130190,
		IdleGsklSyncResponse = 130191,

		IdleGsklUpRequest = 130200,
		IdleGsklUpResponse = 130201,

		IdleGsklResetRequest = 130310,
		IdleGsklResetResponse = 130311,

		IdleGfireSyncRequest = 130340,
		IdleGfireSyncResponse = 130341,

		IdleGfireRegRequest = 130350,
		IdleGfireRegResponse = 130351,

		IdleGfireFightRequest = 130360,
		IdleGfireFightResponse = 130361,

		IdleGfireRankRequest = 130370,
		IdleGfireRankResponse = 130371,

		IdleGveSyncRequest = 130380,
		IdleGveSyncResponse = 130381,

		IdleGveRankRequest = 130390,
		IdleGveRankResponse = 130391,

		IdleGveFightRequest = 130400,
		IdleGveFightResponse = 130401,

		IdleGveTaskRequest = 130410,
		IdleGveTaskResponse = 130411,

		IdleGveClaimRequest = 130420,
		IdleGveClaimResponse = 130421,

		IdleGveMapClaimRequest = 130430,
		IdleGveMapClaimResponse = 130431,

		IdleTrialRequest = 14010,
		IdleTrialResponse = 14011,

		IdleTrialRankRequest = 14020,
		IdleTrialRankResponse = 14021,

		IdleTrialFightRequest = 14030,
		IdleTrialFightResponse = 14031,

		IdleTrialVideoRequest = 14040,
		IdleTrialVideoResponse = 14041,

		IdleTrialTlRequest = 14050,
		IdleTrialTlResponse = 14051,

		IdlePvpSyncRequest = 15010,
		IdlePvpSyncResponse = 15011,

		IdlePvpCampRequest = 15020,
		IdlePvpCampResponse = 15021,

		IdlePvpRefreshRequest = 15030,
		IdlePvpRefreshResponse = 15031,

		IdlePvpFightRequest = 15040,
		IdlePvpFightResponse = 15041,

		IdlePlogsRequest = 15050,
		IdlePlogsResponse = 15051,

		IdlePvpRankRequest = 15060,
		IdlePvpRankResponse = 15061,

		IdleVideoRequest = 15070,
		IdleVideoResponse = 15071,

		IdlePvpTicketRequest = 15080,
		IdlePvpTicketResponse = 15081,

		IdlePmarketRequest = 15090,
		IdlePmarketResponse = 15091,

		IdlePmarketBuyRequest = 150100,
		IdlePmarketBuyResponse = 150101,

		IdleJoinpvpSyncRequest = 150110,
		IdleJoinpvpSyncResponse = 150111,

		IdleP3pSyncRequest = 150120,
		IdleP3pSyncResponse = 150121,

		IdleP3pCampRequest = 150130,
		IdleP3pCampResponse = 150131,

		IdleP3pMatchRequest = 150140,
		IdleP3pMatchResponse = 150141,

		IdleP3pFightRequest = 150150,
		IdleP3pFightResponse = 150151,

		IdleP3pHonorRequest = 150160,
		IdleP3pHonorResponse = 150161,

		IdleP3pLogsRequest = 150170,
		IdleP3pLogsResponse = 150171,

		IdleP3pVideoRequest = 150180,
		IdleP3pVideoResponse = 150181,

		IdleP3pInfoRequest = 150190,
		IdleP3pInfoResponse = 150191,

		IdleFpkCampRequest = 150200,
		IdleFpkCampResponse = 150201,

		IdleHtaskRequest = 16010,
		IdleHtaskResponse = 16011,

		IdleHtaskStartRequest = 16020,
		IdleHtaskStartResponse = 16021,

		IdleHtaskSpeedupRequest = 16030,
		IdleHtaskSpeedupResponse = 16031,

		IdleHtaskRecRequest = 16040,
		IdleHtaskRecResponse = 16041,

		IdleHtaskGemRequest = 16050,
		IdleHtaskGemResponse = 16051,

		IdleHtaskAddRequest = 16070,
		IdleHtaskAddResponse = 16071,

		IdleHtaskAutoRequest = 16080,
		IdleHtaskAutoResponse = 16081,

		IdleAchieveRequest = 17010,
		IdleAchieveResponse = 17011,

		IdleAchieveClaimRequest = 17020,
		IdleAchieveClaimResponse = 17021,

		IdleAchievieAttentionRequest = 17030,
		IdleAchievieAttentionResponse = 17031,

		IdlePayRequest = 18010,
		IdlePayResponse = 18011,

		IdleFpayRequest = 18020,
		IdleFpayResponse = 18021,

		IdlePay2Request = 18030,
		IdlePay2Response = 18031,

		IdleGorderRequest = 18040,
		IdleGorderResponse = 18041,

		IdleGpayRequest = 18050,
		IdleGpayResponse = 18051,

		IdleChpayRequest = 18060,
		IdleChpayResponse = 18061,

		IdleAmznpayRequest = 18070,
		IdleAmznpayResponse = 18071,

		IdleOneforumRequest = 180100,
		IdleOneforumResponse = 180101,

		IdleGpay2Request = 180110,
		IdleGpay2Response = 180111,

		IdleVoucherRequest = 180120,
		IdleVoucherResponse = 180121,

		IdleStoreinfoRequest = 180130,
		IdleStoreinfoResponse = 180131,

		IdleHmarketBuyRequest = 19010,
		IdleHmarketBuyResponse = 19011,

		IdleHmarketSyncRequest = 19020,
		IdleHmarketSyncResponse = 19021,

		IdleBraveMarketBuyRequest = 19030,
		IdleBraveMarketBuyResponse = 19031,

		IdleBraveMarketSyncRequest = 19040,
		IdleBraveMarketSyncResponse = 19041,

		IdleHmarketRefreshRequest = 19050,
		IdleHmarketRefreshResponse = 19051,

		IdleAloginRequest = 20010,
		IdleAloginResponse = 20011,

		IdleTaskClaimRequest = 20020,
		IdleTaskClaimResponse = 20021,

		IdleOnlineClaimRequest = 20030,
		IdleOnlineClaimResponse = 20031,

		IdleFeedbackRequest = 21010,
		IdleFeedbackResponse = 21011,

		IdleGmarketBuyRequest = 22010,
		IdleGmarketBuyResponse = 22011,

		IdleGmarketSyncRequest = 22020,
		IdleGmarketSyncResponse = 22021,

		IdleGmarketRefreshRequest = 22030,
		IdleGmarketRefreshResponse = 22031,

		IdleGmarketExchangeRequest = 22040,
		IdleGmarketExchangeResponse = 22041,

		IdleMergeTreasureRequest = 6030,
		IdleMergeTreasureResponse = 6031,

		IdleNgwSyncRequest = 240120,
		IdleNgwSyncResponse = 240121,

		IdleNgwRankRequest = 240130,
		IdleNgwRankResponse = 240131,

		IdleNgwCampRequest = 240140,
		IdleNgwCampResponse = 240141,

		IdleNgwSholdRequest = 240150,
		IdleNgwSholdResponse = 240151,

		IdleNgwFightRequest = 240160,
		IdleNgwFightResponse = 240161,

		IdleNgwLupRequest = 240180,
		IdleNgwLupResponse = 240181,

		IdleNgwSetupRequest = 240190,
		IdleNgwSetupResponse = 240191,

		IdleNgwBuyRequest = 240210,
		IdleNgwBuyResponse = 240211,

		IdleNgwInfoRequest = 240220,
		IdleNgwInfoResponse = 240221,

		IdleNgwVideoRequest = 240230,
		IdleNgwVideoResponse = 240231,

		IdleNgwSweepRequest = 240240,
		IdleNgwSweepResponse = 240241,

		IdleCgwSyncRequest = 240300,
		IdleCgwSyncResponse = 240301,

		IdleCgwTeamRequest = 240310,
		IdleCgwTeamResponse = 240311,

		IdleCgwRegRequest = 240320,
		IdleCgwRegResponse = 240321,

		IdleCgwHonorRequest = 240330,
		IdleCgwHonorResponse = 240331,

		IdleCgwRecordRequest = 240340,
		IdleCgwRecordResponse = 240341,

		IdleCgwRaceRequest = 240350,
		IdleCgwRaceResponse = 240351,

		IdleCgwLogRequest = 240360,
		IdleCgwLogResponse = 240361,

		IdleGpvpSyncRequest = 26010,
		IdleGpvpSyncResponse = 26011,

		IdleGpvpSetCampRequest = 26020,
		IdleGpvpSetCampResponse = 26021,

		IdleCreateGpvpteamRequest = 26030,
		IdleCreateGpvpteamResponse = 26031,

		IdleDismissGpvpteamRequest = 26040,
		IdleDismissGpvpteamResponse = 26041,

		IdleGpvpMatchRequest = 26050,
		IdleGpvpMatchResponse = 26051,

		IdleSubmitGpvpteamRequest = 26070,
		IdleSubmitGpvpteamResponse = 26071,

		IdleGpvpLeaderopRequest = 26080,
		IdleGpvpLeaderopResponse = 26081,

		IdleGpvpFriendslistRequest = 26090,
		IdleGpvpFriendslistResponse = 26091,

		IdleGpvpInvitelistRequest = 260110,
		IdleGpvpInvitelistResponse = 260111,

		IdleGpvpRefreshRequest = 260120,
		IdleGpvpRefreshResponse = 260121,

		IdleGpvpMbropRequest = 260130,
		IdleGpvpMbropResponse = 260131,

		IdleGpvpRanklistRequest = 260140,
		IdleGpvpRanklistResponse = 260141,

		IdleChangeGpvpteamRequest = 260150,
		IdleChangeGpvpteamResponse = 260151,

		IdleGpvpApplylistRequest = 260160,
		IdleGpvpApplylistResponse = 260161,

		IdleGpvpMbrRequest = 260170,
		IdleGpvpMbrResponse = 260171,

		IdleGpvpGrpRequest = 260180,
		IdleGpvpGrpResponse = 260181,

		IdleGpvpFightRequest = 260190,
		IdleGpvpFightResponse = 260191,

		IdleGpvpLogsRequest = 260200,
		IdleGpvpLogsResponse = 260201,

		IdleGpvpWlogRequest = 260210,
		IdleGpvpWlogResponse = 260211,

		IdleGpvpVideoRequest = 260220,
		IdleGpvpVideoResponse = 260221,

		IdlePetOpRequest = 27010,
		IdlePetOpResponse = 27011,

		IdleBbossBuyRequest = 29020,
		IdleBbossBuyResponse = 29021,

		IdleBbossSynRequest = 29010,
		IdleBbossSynResponse = 29011,

		IdleBbossFightRequest = 29030,
		IdleBbossFightResponse = 29031,

		IdleBbossBatchRequest = 29040,
		IdleBbossBatchResponse = 29041,

		IdleSpkSyncRequest = 28010,
		IdleSpkSyncResponse = 28011,

		IdleSpkCampRequest = 28020,
		IdleSpkCampResponse = 28021,

		IdleSpkFightRequest = 28030,
		IdleSpkFightResponse = 28031,

		IdleSpkBufRequest = 28040,
		IdleSpkBufResponse = 28041,

		IdleSpkRankRequest = 28050,
		IdleSpkRankResponse = 28051,

		IdleSpkBuyRequest = 28060,
		IdleSpkBuyResponse = 28061,

		IdleIslandSyncRequest = 30010,
		IdleIslandSyncResponse = 30011,

		IdleIslandTowerRequest = 30020,
		IdleIslandTowerResponse = 30021,

		IdleIslandOpRequest = 30030,
		IdleIslandOpResponse = 30031,

		IdleIslandLandRequest = 30040,
		IdleIslandLandResponse = 30041,

		IdleIslandBoxRequest = 30050,
		IdleIslandBoxResponse = 30051,

		IdleIslandNpcRequest = 30060,
		IdleIslandNpcResponse = 30061,

		IdleIslandBossRequest = 30070,
		IdleIslandBossResponse = 30071,

		IdleIslandFightRequest = 30080,
		IdleIslandFightResponse = 30081,

		IdleIslandBuyRequest = 30090,
		IdleIslandBuyResponse = 30091,

		IdleIslandBatchRequest = 300100,
		IdleIslandBatchResponse = 300101,

		IdleIslandSweepRequest = 300110,
		IdleIslandSweepResponse = 300111,

		IdleIslandBgetRequest = 300120,
		IdleIslandBgetResponse = 300121,

		IdleIslandIboatSyncRequest = 300130,
		IdleIslandIboatSyncResponse = 300131,

		IdleIslandIboatStartRequest = 300140,
		IdleIslandIboatStartResponse = 300141,

		IdleIslandIboatXpRequest = 300150,
		IdleIslandIboatXpResponse = 300151,

		IdleIslandIboatXpopRequest = 300160,
		IdleIslandIboatXpopResponse = 300161,

		IdleIslandIboatShopRequest = 300170,
		IdleIslandIboatShopResponse = 300171,

		IdleIslandIboatBuyRequest = 300180,
		IdleIslandIboatBuyResponse = 300181,

		IdleIslandIboatArmRequest = 300190,
		IdleIslandIboatArmResponse = 300191,

		IdleIslandIboatSklRequest = 300200,
		IdleIslandIboatSklResponse = 300201,

		IdleIslandIboatNameRequest = 300210,
		IdleIslandIboatNameResponse = 300211,

		IdleIslandIboatFsyncRequest = 300220,
		IdleIslandIboatFsyncResponse = 300221,

		IdleIslandIboatFproRequest = 300230,
		IdleIslandIboatFproResponse = 300231,

		IdleIslandIboatUseRequest = 300240,
		IdleIslandIboatUseResponse = 300241,

		IdleBeatNienRequest = 31010,
		IdleBeatNienResponse = 31011,

		IdleSeallandSyncRequest = 90160,
		IdleSeallandSyncResponse = 90161,

		IdleSeallandChallengeBuyRequest = 90170,
		IdleSeallandChallengeBuyResponse = 90171,

		IdleSeallandFightRequest = 90180,
		IdleSeallandFightResponse = 90181,

		IdleSeallandRewardRequest = 90190,
		IdleSeallandRewardResponse = 90191,

		IdleSeallandSweepBuyRequest = 90200,
		IdleSeallandSweepBuyResponse = 90201,

		IdleSeallandMarketBuyRequest = 90210,
		IdleSeallandMarketBuyResponse = 90211,

		IdleBraveSweepRequest = 90220,
		IdleBraveSweepResponse = 90221,

		IdleMonthmarketBuyRequest = 33010,
		IdleMonthmarketBuyResponse = 33011,

		IdleMonthmarketSyncRequest = 33020,
		IdleMonthmarketSyncResponse = 33021,

		IdleActivityRequest = 31020,
		IdleActivityResponse = 31021,

		IdleActivitySignRequest = 31030,
		IdleActivitySignResponse = 31031,

		IdleMazeOpenRequest = 310200,
		IdleMazeOpenResponse = 310201,

		IdleMazeChangeHeroRequest = 310210,
		IdleMazeChangeHeroResponse = 310211,

		IdleMazeOpen2Request = 310220,
		IdleMazeOpen2Response = 310221,

		IdleMazeBuyRequest = 310230,
		IdleMazeBuyResponse = 310231,

		IdleMazeSyncRequest = 310240,
		IdleMazeSyncResponse = 310241,

		IdleMazeBreakRequest = 310250,
		IdleMazeBreakResponse = 310251,

		IdleFetchSactRequest = 310260,
		IdleFetchSactResponse = 310261,

		IdleSactSummerBuyRequest = 36010,
		IdleSactSummerBuyResponse = 36011,

		IdleHeroLogRequest = 37010,
		IdleHeroLogResponse = 37011,

		IdleBraveOpenRequest = 38010,
		IdleBraveOpenResponse = 38011,

		IdleBraveAltarRequest = 38020,
		IdleBraveAltarResponse = 38021,

		IdleBraveBuyRequest = 38030,
		IdleBraveBuyResponse = 38031,

		IdleWpvpSyncRequest = 39010,
		IdleWpvpSyncResponse = 39011,

		IdleWpvpHonorRequest = 39020,
		IdleWpvpHonorResponse = 39021,

		IdleWpvpDailyRequest = 39030,
		IdleWpvpDailyResponse = 39031,

		IdleWpvpMatchRequest = 39040,
		IdleWpvpMatchResponse = 39041,

		IdleWpvpCampRequest = 39050,
		IdleWpvpCampResponse = 39051,

		IdleWpvpFightRequest = 39060,
		IdleWpvpFightResponse = 39061,

		IdleWpvpLikeRequest = 39070,
		IdleWpvpLikeResponse = 39071,

		IdleWpvpInfoRequest = 39080,
		IdleWpvpInfoResponse = 39081,

		IdleWpvpZoneRequest = 39090,
		IdleWpvpZoneResponse = 39091,

		IdleWpvpLoger1Request = 390100,
		IdleWpvpLoger1Response = 390101,

		IdleWpvpLog1Request = 390110,
		IdleWpvpLog1Response = 390111,

		IdleWpvpVideo1Request = 390120,
		IdleWpvpVideo1Response = 390121,

		IdleWpvpLog2Request = 390130,
		IdleWpvpLog2Response = 390131,

		IdleWpvpVideo2Request = 390140,
		IdleWpvpVideo2Response = 390141,

		IdleTutorialRequest = 40010,
		IdleTutorialResponse = 40011,

		IdleRactReceiveRequest = 41010,
		IdleRactReceiveResponse = 41011,

		IdleRactPowerRequest = 41020,
		IdleRactPowerResponse = 41021,

		IdleTaskConvertRequest = 20040,
		IdleTaskConvertResponse = 20041,

		IdleFetchActivityRequest = 31060,
		IdleFetchActivityResponse = 31061,

		IdleMonopolyDiceRequest = 310100,
		IdleMonopolyDiceResponse = 310101,

		IdleBuyDiceRequest = 310110,
		IdleBuyDiceResponse = 310111,

		IdleYoutuberRefreshRequest = 310140,
		IdleYoutuberRefreshResponse = 310141,

		IdleForgeBackRequest = 310150,
		IdleForgeBackResponse = 310151,

		IdleGoldCardRequest = 310160,
		IdleGoldCardResponse = 310161,

		IdleLimitGiftActivateRequest = 310180,
		IdleLimitGiftActivateResponse = 310181,

		IdleFollowRequest = 310190,
		IdleFollowResponse = 310191,

		IdleHtaskCommitRequest = 310300,
		IdleHtaskCommitResponse = 310301,

		IdleReSyncRequest = 34010,
		IdleReSyncResponse = 34011,

		IdleReCodeRequest = 34020,
		IdleReCodeResponse = 34021,

		IdleReBindRequest = 34030,
		IdleReBindResponse = 34031,

		IdleForgeArtifactRequest = 31080,
		IdleForgeArtifactResponse = 31081,

		IdleCrackArtifactRequest = 31090,
		IdleCrackArtifactResponse = 31091,

		IdleHeroForeverRequest = 310120,
		IdleHeroForeverResponse = 310121,

		IdleStSyncRequest = 42010,
		IdleStSyncResponse = 42011,

		IdleStSummonRequest = 42020,
		IdleStSummonResponse = 42021,

		IdleStSchangeRequest = 42030,
		IdleStSchangeResponse = 42031,

		IdleStRankRequest = 42050,
		IdleStRankResponse = 42051,

		IdleStHforgeRequest = 42060,
		IdleStHforgeResponse = 42061,

		IdleStHattrupRequest = 42070,
		IdleStHattrupResponse = 42071,

		IdleStHattrchangeRequest = 42080,
		IdleStHattrchangeResponse = 42081,

		IdleStHattractivateRequest = 42090,
		IdleStHattractivateResponse = 42091,

		IdleStVsyncRequest = 420100,
		IdleStVsyncResponse = 420101,

		IdleStVsync2Request = 420110,
		IdleStVsync2Response = 420111,

		IdleStVeventRequest = 420120,
		IdleStVeventResponse = 420121,

		IdleStVdiffRequest = 420130,
		IdleStVdiffResponse = 420131,

		IdleStHeartresolveRequest = 420140,
		IdleStHeartresolveResponse = 420141,

		IdleStVwipeRequest = 420150,
		IdleStVwipeResponse = 420151,

		IdleStVuseitemRequest = 420160,
		IdleStVuseitemResponse = 420161,

		IdleStEsyncRequest = 420170,
		IdleStEsyncResponse = 420171,

		IdleStEbuyRequest = 420180,
		IdleStEbuyResponse = 420181,

		IdleStEuseRequest = 420190,
		IdleStEuseResponse = 420191,

		IdleStEfightRequest = 420200,
		IdleStEfightResponse = 420201,

		IdleStErank1Request = 420210,
		IdleStErank1Response = 420211,

		IdleStErank2Request = 420220,
		IdleStErank2Response = 420221,

		IdleStEgetRequest = 420230,
		IdleStEgetResponse = 420231,

		IdleStEopenRequest = 420240,
		IdleStEopenResponse = 420241,

		IdleStAsyncRequest = 420250,
		IdleStAsyncResponse = 420251,

		IdleStErefreshRequest = 420260,
		IdleStErefreshResponse = 420261,

		IdleStHattrresetRequest = 420270,
		IdleStHattrresetResponse = 420271,

		IdleStTbackRequest = 420280,
		IdleStTbackResponse = 420281,

		IdleStChangenightRequest = 420290,
		IdleStChangenightResponse = 420291,

		IdleStStarresolveRequest = 420300,
		IdleStStarresolveResponse = 420301,

		IdleStSsyncRequest = 420360,
		IdleStSsyncResponse = 420361,

		IdleStSlvupRequest = 420370,
		IdleStSlvupResponse = 420371,

		IdleStSsweepRequest = 420380,
		IdleStSsweepResponse = 420381,

		IdleStSsklupRequest = 420390,
		IdleStSsklupResponse = 420391,

		IdleStSstoreRequest = 420400,
		IdleStSstoreResponse = 420401,

		IdleStSbuyRequest = 420410,
		IdleStSbuyResponse = 420411,

		IdleStSmapUnlockRequest = 420420,
		IdleStSmapUnlockResponse = 420421,

		IdleStSmapSyncRequest = 420430,
		IdleStSmapSyncResponse = 420431,

		IdleStScellUnlockRequest = 420440,
		IdleStScellUnlockResponse = 420441,

		IdleStScellDispRequest = 420450,
		IdleStScellDispResponse = 420451,

		IdleStScellFightRequest = 420460,
		IdleStScellFightResponse = 420461,

		IdleStSmapSettRequest = 420470,
		IdleStSmapSettResponse = 420471,

		IdleStSmapTeamRequest = 420480,
		IdleStSmapTeamResponse = 420481,

		IdleStSmapRankRequest = 420490,
		IdleStSmapRankResponse = 420491,

		IdleStSmapMbrRequest = 420500,
		IdleStSmapMbrResponse = 420501,

		IdleStSclickRequest = 420510,
		IdleStSclickResponse = 420511,

		IdleSpetResetRequest = 420530,
		IdleSpetResetResponse = 420531,

		IdleLobiVoteRequest = 310130,
		IdleLobiVoteResponse = 310131,

		IdleStowerSyncRequest = 420310,
		IdleStowerSyncResponse = 420311,

		IdleStowerUpRequest = 420320,
		IdleStowerUpResponse = 420321,

		IdleStowerHatchRequest = 420330,
		IdleStowerHatchResponse = 420331,

		IdleStowerHoverRequest = 420340,
		IdleStowerHoverResponse = 420341,

		IdleSpetUpRequest = 420350,
		IdleSpetUpResponse = 420351,

		IdleStHchangeRequest = 420520,
		IdleStHchangeResponse = 420521,

		IdleNtaskSyncRequest = 43010,
		IdleNtaskSyncResponse = 43011,

		IdleNtaskClaimRequest = 43020,
		IdleNtaskClaimResponse = 43021,

	}
}
