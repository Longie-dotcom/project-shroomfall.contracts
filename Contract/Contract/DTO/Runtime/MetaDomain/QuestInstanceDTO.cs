using Contract.Enum.MetaDomain.Quest;
using System;
using System.Collections.Generic;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Runtime.MetaDomain
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/runtime/meta-domain")]
#endif
    public class QuestInstanceDTO
    {
#if NET9_0
        [TsOptional]
#endif
        public string? Id { get; set; } = string.Empty;
        public QuestType Type { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ExpiredAt { get; set; }
        public QuestRewardConfig QuestRewardConfig { get; set; } = new QuestRewardConfig();
#if NET9_0
        [TsOptional]
#endif
        public IdentificationQuestConfig? IdentificationConfig { get; set; }
#if NET9_0
        [TsOptional]
#endif
        public CategorizingQuestConfig? CategorizingConfig { get; set; }
#if NET9_0
        [TsOptional]
#endif
        public ShootingQuestConfig? ShootingConfig { get; set; }
    }

    #region Identification Config
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/runtime/meta-domain")]
#endif
    public class IdentificationQuestConfig
    {
        public LocaleQuestDTO Description { get; set; } = new LocaleQuestDTO();
        public string TargetMushroomDefinitionId { get; set; } = string.Empty;
        public int RequiredDefeatCount { get; set; }
    }
    #endregion

    #region Categorizing Config
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/runtime/meta-domain")]
#endif
    public class CategorizingQuestConfig
    {
        public LocaleQuestDTO Description { get; set; } = new LocaleQuestDTO();
        public List<CategorizingCategoryConfigDTO> Categories { get; set; } = new List<CategorizingCategoryConfigDTO>();
        public List<CategorizingItemConfigDTO> Items { get; set; } = new List<CategorizingItemConfigDTO>();
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "dto/runtime/meta-domain")]
#endif
    public class CategorizingCategoryConfigDTO
    {
        public string Id { get; set; } = string.Empty;
        public LocaleQuestDTO CategoryName { get; set; } = new LocaleQuestDTO();
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "dto/runtime/meta-domain")]
#endif
    public class CategorizingItemConfigDTO
    {
        public string Id { get; set; } = string.Empty;
        public string MushroomDefinitionId { get; set; } = string.Empty;
        public string CorrectCategoryId { get; set; } = string.Empty;
    }
    #endregion

    #region Shooting Config
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/runtime/meta-domain")]
#endif
    public class ShootingQuestConfig
    {
        public LocaleQuestDTO Description { get; set; } = new LocaleQuestDTO();
        public List<ShootingMushroomConfigDTO> Mushrooms { get; set; } = new List<ShootingMushroomConfigDTO>();
        public List<ShootingQuestionConfigDTO> Questions { get; set; } = new List<ShootingQuestionConfigDTO>();
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "dto/runtime/meta-domain")]
#endif
    public class ShootingMushroomConfigDTO
    {
        public string MushroomDefinitionId { get; set; } = string.Empty;
        public int SpawnCount { get; set; }
        public float MovementSpeed { get; set; }
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "dto/runtime/meta-domain")]
#endif
    public class ShootingQuestionConfigDTO
    {
        public string Id { get; set; } = string.Empty;
        public LocaleQuestDTO Question { get; set; } = new LocaleQuestDTO();
        public string CorrectMushroomDefinitionId { get; set; } = string.Empty;
        public int TimeLimitSeconds { get; set; }
    }
    #endregion

    #region Reward Config
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/runtime/meta-domain")]
#endif
    public class QuestRewardConfig
    {
        public int CurrencyAmount { get; set; }
        public List<GachaRewardEntryDTO> Entries { get; set; } = new List<GachaRewardEntryDTO>();
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "dto/runtime/meta-domain")]
#endif
    public class GachaRewardEntryDTO
    {
        public string Id { get; set; } = string.Empty;
        public string ItemDefinitionId { get; set; } = string.Empty;
        public int Amount { get; set; } = 1;
        public float Weight { get; set; }
    }
    #endregion

#if NET9_0
    [ExportTsInterface(OutputDir = "dto/runtime/meta-domain")]
#endif
    public class LocaleQuestDTO
    {
        public List<LocaleEntryDTO> Entries { get; set; } = new List<LocaleEntryDTO>();
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "dto/runtime/meta-domain")]
#endif
    public class LocaleEntryDTO
    {
        public string Key { get; set; } = string.Empty;

        public string Value { get; set; } = string.Empty;
    }
}