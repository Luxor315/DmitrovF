/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class feed
{

    private byte feed_versionField;

    private feedObject[] objectField;

    /// <remarks/>
    public byte feed_version
    {
        get
        {
            return this.feed_versionField;
        }
        set
        {
            this.feed_versionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("object")]
    public feedObject[] @object
    {
        get
        {
            return this.objectField;
        }
        set
        {
            this.objectField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class feedObject
{

    private string categoryField;

    private string externalIdField;

    private string room_articulField;

    private string statusField;

    private string descriptionField;

    private string addressField;

    private feedObjectCoordinates coordinatesField;

    private string urlField;

    private feedObjectPhones phonesField;

    private feedObjectPhotos photosField;

    private bool isDachaField;

    private bool hasElectricityField;

    private bool hasWaterField;

    private byte bedroomsCountField;

    private bool hasGasField;

    private bool hasDrainageField;

    private string repairTypeField;

    private bool hasPhoneField;

    private bool hasSecurityField;

    private bool isInHiddenBaseField;

    private bool hasBathhouseField;

    private bool hasGarageField;

    private bool hasPoolField;

    private bool hasConditionerField;

    private string sizeField;

    private string decorationField;

    private string totalAreaField;

    private feedObjectJKSchema jKSchemaField;

    private feedObjectBuilding buildingField;

    private feedObjectLand landField;

    private feedObjectHouse houseField;

    private feedObjectBargainTerms bargainTermsField;

    private string mortgagePaymentField;

    /// <remarks/>
    public string Category
    {
        get
        {
            return this.categoryField;
        }
        set
        {
            this.categoryField = value;
        }
    }

    /// <remarks/>
    public string ExternalId
    {
        get
        {
            return this.externalIdField;
        }
        set
        {
            this.externalIdField = value;
        }
    }

    /// <remarks/>
    public string room_articul
    {
        get
        {
            return this.room_articulField;
        }
        set
        {
            this.room_articulField = value;
        }
    }

    /// <remarks/>
    public string Status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }

    /// <remarks/>
    public string Description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }

    /// <remarks/>
    public string Address
    {
        get
        {
            return this.addressField;
        }
        set
        {
            this.addressField = value;
        }
    }

    /// <remarks/>
    public feedObjectCoordinates Coordinates
    {
        get
        {
            return this.coordinatesField;
        }
        set
        {
            this.coordinatesField = value;
        }
    }

    /// <remarks/>
    public string Url
    {
        get
        {
            return this.urlField;
        }
        set
        {
            this.urlField = value;
        }
    }

    /// <remarks/>
    public feedObjectPhones Phones
    {
        get
        {
            return this.phonesField;
        }
        set
        {
            this.phonesField = value;
        }
    }

    /// <remarks/>
    public feedObjectPhotos Photos
    {
        get
        {
            return this.photosField;
        }
        set
        {
            this.photosField = value;
        }
    }

    /// <remarks/>
    public bool IsDacha
    {
        get
        {
            return this.isDachaField;
        }
        set
        {
            this.isDachaField = value;
        }
    }

    /// <remarks/>
    public bool HasElectricity
    {
        get
        {
            return this.hasElectricityField;
        }
        set
        {
            this.hasElectricityField = value;
        }
    }

    /// <remarks/>
    public bool HasWater
    {
        get
        {
            return this.hasWaterField;
        }
        set
        {
            this.hasWaterField = value;
        }
    }

    /// <remarks/>
    public byte BedroomsCount
    {
        get
        {
            return this.bedroomsCountField;
        }
        set
        {
            this.bedroomsCountField = value;
        }
    }

    /// <remarks/>
    public bool HasGas
    {
        get
        {
            return this.hasGasField;
        }
        set
        {
            this.hasGasField = value;
        }
    }

    /// <remarks/>
    public bool HasDrainage
    {
        get
        {
            return this.hasDrainageField;
        }
        set
        {
            this.hasDrainageField = value;
        }
    }

    /// <remarks/>
    public string RepairType
    {
        get
        {
            return this.repairTypeField;
        }
        set
        {
            this.repairTypeField = value;
        }
    }

    /// <remarks/>
    public bool HasPhone
    {
        get
        {
            return this.hasPhoneField;
        }
        set
        {
            this.hasPhoneField = value;
        }
    }

    /// <remarks/>
    public bool HasSecurity
    {
        get
        {
            return this.hasSecurityField;
        }
        set
        {
            this.hasSecurityField = value;
        }
    }

    /// <remarks/>
    public bool IsInHiddenBase
    {
        get
        {
            return this.isInHiddenBaseField;
        }
        set
        {
            this.isInHiddenBaseField = value;
        }
    }

    /// <remarks/>
    public bool HasBathhouse
    {
        get
        {
            return this.hasBathhouseField;
        }
        set
        {
            this.hasBathhouseField = value;
        }
    }

    /// <remarks/>
    public bool HasGarage
    {
        get
        {
            return this.hasGarageField;
        }
        set
        {
            this.hasGarageField = value;
        }
    }

    /// <remarks/>
    public bool HasPool
    {
        get
        {
            return this.hasPoolField;
        }
        set
        {
            this.hasPoolField = value;
        }
    }

    /// <remarks/>
    public bool HasConditioner
    {
        get
        {
            return this.hasConditionerField;
        }
        set
        {
            this.hasConditionerField = value;
        }
    }

    /// <remarks/>
    public string Size
    {
        get
        {
            return this.sizeField;
        }
        set
        {
            this.sizeField = value;
        }
    }

    /// <remarks/>
    public string Decoration
    {
        get
        {
            return this.decorationField;
        }
        set
        {
            this.decorationField = value;
        }
    }

    /// <remarks/>
    public string TotalArea
    {
        get
        {
            return this.totalAreaField;
        }
        set
        {
            this.totalAreaField = value;
        }
    }

    /// <remarks/>
    public feedObjectJKSchema JKSchema
    {
        get
        {
            return this.jKSchemaField;
        }
        set
        {
            this.jKSchemaField = value;
        }
    }

    /// <remarks/>
    public feedObjectBuilding Building
    {
        get
        {
            return this.buildingField;
        }
        set
        {
            this.buildingField = value;
        }
    }

    /// <remarks/>
    public feedObjectLand Land
    {
        get
        {
            return this.landField;
        }
        set
        {
            this.landField = value;
        }
    }

    /// <remarks/>
    public feedObjectHouse House
    {
        get
        {
            return this.houseField;
        }
        set
        {
            this.houseField = value;
        }
    }

    /// <remarks/>
    public feedObjectBargainTerms BargainTerms
    {
        get
        {
            return this.bargainTermsField;
        }
        set
        {
            this.bargainTermsField = value;
        }
    }

    /// <remarks/>
    public string MortgagePayment
    {
        get
        {
            return this.mortgagePaymentField;
        }
        set
        {
            this.mortgagePaymentField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class feedObjectCoordinates
{

    private decimal latField;

    private decimal lngField;

    /// <remarks/>
    public decimal Lat
    {
        get
        {
            return this.latField;
        }
        set
        {
            this.latField = value;
        }
    }

    /// <remarks/>
    public decimal Lng
    {
        get
        {
            return this.lngField;
        }
        set
        {
            this.lngField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class feedObjectPhones
{

    private feedObjectPhonesPhoneSchema phoneSchemaField;

    private string[] textField;

    /// <remarks/>
    public feedObjectPhonesPhoneSchema PhoneSchema
    {
        get
        {
            return this.phoneSchemaField;
        }
        set
        {
            this.phoneSchemaField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Text
    {
        get
        {
            return this.textField;
        }
        set
        {
            this.textField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class feedObjectPhonesPhoneSchema
{

    private sbyte countryCodeField;

    private ulong numberField;

    /// <remarks/>
    public sbyte CountryCode
    {
        get
        {
            return this.countryCodeField;
        }
        set
        {
            this.countryCodeField = value;
        }
    }

    /// <remarks/>
    public ulong Number
    {
        get
        {
            return this.numberField;
        }
        set
        {
            this.numberField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class feedObjectPhotos
{

    private feedObjectPhotosPhotoSchema[] photoSchemaField;

    private string[] textField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PhotoSchema")]
    public feedObjectPhotosPhotoSchema[] PhotoSchema
    {
        get
        {
            return this.photoSchemaField;
        }
        set
        {
            this.photoSchemaField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Text
    {
        get
        {
            return this.textField;
        }
        set
        {
            this.textField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class feedObjectPhotosPhotoSchema
{

    private string fullUrlField;

    private bool isDefaultField;

    private string photoTypeField;

    /// <remarks/>
    public string FullUrl
    {
        get
        {
            return this.fullUrlField;
        }
        set
        {
            this.fullUrlField = value;
        }
    }

    /// <remarks/>
    public bool IsDefault
    {
        get
        {
            return this.isDefaultField;
        }
        set
        {
            this.isDefaultField = value;
        }
    }

    /// <remarks/>
    public string PhotoType
    {
        get
        {
            return this.photoTypeField;
        }
        set
        {
            this.photoTypeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class feedObjectJKSchema
{

    private ushort idField;

    private string nameField;

    /// <remarks/>
    public ushort Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class feedObjectBuilding
{

    private byte floorsCountField;

    private ushort buildYearField;

    private byte quarterField;

    private ushort yearField;

    /// <remarks/>
    public byte FloorsCount
    {
        get
        {
            return this.floorsCountField;
        }
        set
        {
            this.floorsCountField = value;
        }
    }

    /// <remarks/>
    public ushort BuildYear
    {
        get
        {
            return this.buildYearField;
        }
        set
        {
            this.buildYearField = value;
        }
    }

    /// <remarks/>
    public byte Quarter
    {
        get
        {
            return this.quarterField;
        }
        set
        {
            this.quarterField = value;
        }
    }

    /// <remarks/>
    public ushort Year
    {
        get
        {
            return this.yearField;
        }
        set
        {
            this.yearField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class feedObjectLand
{

    private string areaField;

    private string areaUnitTypeField;

    private string permittedLandUseTypeField;

    private bool isLandWithContractField;

    /// <remarks/>
    public string Area
    {
        get
        {
            return this.areaField;
        }
        set
        {
            this.areaField = value;
        }
    }

    /// <remarks/>
    public string AreaUnitType
    {
        get
        {
            return this.areaUnitTypeField;
        }
        set
        {
            this.areaUnitTypeField = value;
        }
    }

    /// <remarks/>
    public string PermittedLandUseType
    {
        get
        {
            return this.permittedLandUseTypeField;
        }
        set
        {
            this.permittedLandUseTypeField = value;
        }
    }

    /// <remarks/>
    public bool IsLandWithContract
    {
        get
        {
            return this.isLandWithContractField;
        }
        set
        {
            this.isLandWithContractField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class feedObjectHouse
{

    private bool hasTerraceField;

    private bool hasCellarField;

    private feedObjectHouseMaterialTypes materialTypesField;

    /// <remarks/>
    public bool HasTerrace
    {
        get
        {
            return this.hasTerraceField;
        }
        set
        {
            this.hasTerraceField = value;
        }
    }

    /// <remarks/>
    public bool HasCellar
    {
        get
        {
            return this.hasCellarField;
        }
        set
        {
            this.hasCellarField = value;
        }
    }

    /// <remarks/>
    public feedObjectHouseMaterialTypes MaterialTypes
    {
        get
        {
            return this.materialTypesField;
        }
        set
        {
            this.materialTypesField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class feedObjectHouseMaterialTypes
{

    private string materialTypeField;

    /// <remarks/>
    public string MaterialType
    {
        get
        {
            return this.materialTypeField;
        }
        set
        {
            this.materialTypeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class feedObjectBargainTerms
{

    private uint priceField;

    /// <remarks/>
    public uint Price
    {
        get
        {
            return this.priceField;
        }
        set
        {
            this.priceField = value;
        }
    }
}