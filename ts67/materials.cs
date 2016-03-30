singleton Material(ts67)
{
    mapTo = "ts67";
    diffuseMap[1] = "ts67_d.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "ts67_n.png";
    specularPower[0] = "128";
    pixelSpecular[0] = "0";
    diffuseColor[0] = "1 1 1 0";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    instanceDiffuse[2] = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(ts67_wheels)
{
   mapTo = "ts67_wheels";
   diffuseMap[1] = "ts67_wheels_d.dds";
   specularPower[0] = "15";
   useAnisotropic[0] = "1";
   castShadows = "1";
   translucent = "0";
   alphaTest = "0";
   alphaRef = "0";
};

singleton Material(ts67_eng)
{
   mapTo = "ts67_eng";
   diffuseMap[0] = "ts67_engine_d.dds";
   specularPower[0] = "15";
   useAnisotropic[0] = "1";
   castShadows = "1";
   translucent = "0";
   alphaTest = "0";
   alphaRef = "0";
};

singleton Material(ts67_sus)
{
   mapTo = "ts67_sus";
   diffuseMap[0] = "ts67_suspension_d.dds";
   specularPower[0] = "15";
   useAnisotropic[0] = "1";
   castShadows = "1";
   translucent = "0";
   alphaTest = "0";
   alphaRef = "0";
};

singleton Material(ts67_glass)
{
    mapTo = "ts67_glass";
    diffuseMap[0] = "ts67_glass_d.dds";
    specularMap[0] = "ts67_glass_d.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    diffuseColor[0] = "1 1 1 1";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = false;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};