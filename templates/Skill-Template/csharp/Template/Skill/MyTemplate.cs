<VSTemplate Version="3.0.0" xmlns="http://schemas.microsoft.com/developer/vstemplate/2005" Type="Project">
  <TemplateData>
    <Name>Skill</Name>
    <Description>Project template for Bot Framework Skills (including Unit Test project)</Description>
    <SortOrder>1000</SortOrder>
    <CreateNewFolder>true</CreateNewFolder>
    <DefaultName>Skill</DefaultName>
    <ProvideDefaultName>true</ProvideDefaultName>
    <LocationField>Enabled</LocationField>
    <EnableLocationBrowseButton>true</EnableLocationBrowseButton>
    <CreateInPlace>true</CreateInPlace>
    <Icon>__TemplateIcon.ico</Icon>
  </TemplateData>
  <TemplateContent>
    <Project TargetFileName="Skill.csproj" File="Skill.csproj" ReplaceParameters="true">
      <Folder Name="Connected Services" TargetFolderName="Connected Services">
        <Folder Name="Application Insights" TargetFolderName="Application Insights">
          <ProjectItem ReplaceParameters="true" TargetFileName="ConnectedService.json">ConnectedService.json</ProjectItem>
        </Folder>
      </Folder>
      <Folder Name="Properties" TargetFolderName="Properties">
        <ProjectItem ReplaceParameters="true" TargetFileName="launchSettings.json">launchSettings.json</ProjectItem>
      </Folder>
      <Folder Name="wwwroot" TargetFolderName="wwwroot">
        <ProjectItem ReplaceParameters="true" TargetFileName="default.htm">default.htm</ProjectItem>
      </Folder>
      <Folder Name="Adapters" TargetFolderName="Adapters">
        <ProjectItem ReplaceParameters="true" TargetFileName="CustomSkillAdapter.cs">CustomSkillAdapter.cs</ProjectItem>
        <ProjectItem ReplaceParameters="true" TargetFileName="DefaultAdapter.cs">DefaultAdapter.cs</ProjectItem>
      </Folder>
      <Folder Name="Bots" TargetFolderName="Bots">
        <ProjectItem ReplaceParameters="true" TargetFileName="DialogBot.cs">DialogBot.cs</ProjectItem>
      </Folder>
      <Folder Name="Controllers" TargetFolderName="Controllers">
        <ProjectItem ReplaceParameters="true" TargetFileName="BotController.cs">BotController.cs</ProjectItem>
      </Folder>
      <Folder Name="Deployment" TargetFolderName="Deployment">
        <Folder Name="Resources" TargetFolderName="Resources">
          <Folder Name="LU" TargetFolderName="LU">
            <Folder Name="de" TargetFolderName="de">
              <ProjectItem ReplaceParameters="false" TargetFileName="General.lu">general.lu</ProjectItem>
              <ProjectItem ReplaceParameters="false" TargetFileName="$safeprojectname$.lu">skill.lu</ProjectItem>
            </Folder>
            <Folder Name="en" TargetFolderName="en">
              <ProjectItem ReplaceParameters="false" TargetFileName="General.lu">general.lu</ProjectItem>
              <ProjectItem ReplaceParameters="false" TargetFileName="$safeprojectname$.lu">skill.lu</ProjectItem>
            </Folder>
            <Folder Name="es" TargetFolderName="es">
              <ProjectItem ReplaceParameters="false" TargetFileName="General.lu">general.lu</ProjectItem>
              <ProjectItem ReplaceParameters="false" TargetFileName="$safeprojectname$.lu">skill.lu</ProjectItem>
            </Folder>
            <Folder Name="fr" TargetFolderName="fr">
              <ProjectItem ReplaceParameters="false" TargetFileName="General.lu">general.lu</ProjectItem>
              <ProjectItem ReplaceParameters="false" TargetFileName="$safeprojectname$.lu">skill.lu</ProjectItem>
            </Folder>
            <Folder Name="it" TargetFolderName="it">
              <ProjectItem ReplaceParameters="false" TargetFileName="General.lu">general.lu</ProjectItem>
              <ProjectItem ReplaceParameters="false" TargetFileName="$safeprojectname$.lu">skill.lu</ProjectItem>
            </Folder>
            <Folder Name="zh" TargetFolderName="zh">
              <ProjectItem ReplaceParameters="false" TargetFileName="General.lu">general.lu</ProjectItem>
              <ProjectItem ReplaceParameters="false" TargetFileName="$safeprojectname$.lu">skill.lu</ProjectItem>
            </Folder>
          </Folder>
          <ProjectItem ReplaceParameters="true" TargetFileName="parameters.template.json">parameters.template.json</ProjectItem>
          <ProjectItem ReplaceParameters="true" TargetFileName="template.json">template.json</ProjectItem>
        </Folder>
        <Folder Name="Scripts" TargetFolderName="Scripts">
          <ProjectItem ReplaceParameters="false" TargetFileName="deploy.ps1">deploy.ps1</ProjectItem>
          <ProjectItem ReplaceParameters="false" TargetFileName="deploy_cognitive_models.ps1">deploy_cognitive_models.ps1</ProjectItem>
          <ProjectItem ReplaceParameters="false" TargetFileName="luis_functions.ps1">luis_functions.ps1</ProjectItem>
          <ProjectItem ReplaceParameters="false" TargetFileName="update_cognitive_models.ps1">update_cognitive_models.ps1</ProjectItem>
        </Folder>
      </Folder>
      <Folder Name="Dialogs" TargetFolderName="Dialogs">
        <ProjectItem ReplaceParameters="true" TargetFileName="MainDialog.cs">MainDialog.cs</ProjectItem>
        <ProjectItem ReplaceParameters="true" TargetFileName="SampleDialog.cs">SampleDialog.cs</ProjectItem>
        <ProjectItem ReplaceParameters="true" TargetFileName="SkillDialogBase.cs">SkillDialogBase.cs</ProjectItem>
      </Folder>
      <Folder Name="Models" TargetFolderName="Models">
        <ProjectItem ReplaceParameters="true" TargetFileName="SkillState.cs">SkillState.cs</ProjectItem>
      </Folder>
      <Folder Name="Responses" TargetFolderName="Responses">
        <Folder Name="Main" TargetFolderName="Main">
          <ProjectItem ReplaceParameters="true" TargetFileName="MainResponses.tt">MainResponses.tt</ProjectItem>
          <ProjectItem ReplaceParameters="true" TargetFileName="MainResponses.cs">MainResponses.cs</ProjectItem>
          <ProjectItem ReplaceParameters="true" TargetFileName="MainResponses.json">MainResponses.json</ProjectItem>
          <ProjectItem ReplaceParameters="true" TargetFileName="MainResponses.de.json">MainResponses.de.json</ProjectItem>
          <ProjectItem ReplaceParameters="true" TargetFileName="MainResponses.es.json">MainResponses.es.json</ProjectItem>
          <ProjectItem ReplaceParameters="true" TargetFileName="MainResponses.fr.json">MainResponses.fr.json</ProjectItem>
          <ProjectItem ReplaceParameters="true" TargetFileName="MainResponses.it.json">MainResponses.it.json</ProjectItem>
          <ProjectItem ReplaceParameters="true" TargetFileName="MainResponses.zh.json">MainResponses.zh.json</ProjectItem>
        </Folder>
        <Folder Name="Sample" TargetFolderName="Sample">
          <ProjectItem ReplaceParameters="true" TargetFileName="SampleResponses.tt">SampleResponses.tt</ProjectItem>
          <ProjectItem ReplaceParameters="true" TargetFileName="SampleResponses.cs">SampleResponses.cs</ProjectItem>
          <ProjectItem ReplaceParameters="true" TargetFileName="SampleResponses.json">SampleResponses.json</ProjectItem>
          <ProjectItem ReplaceParameters="true" TargetFileName="SampleResponses.de.json">SampleResponses.de.json</ProjectItem>
          <ProjectItem ReplaceParameters="true" TargetFileName="SampleResponses.es.json">SampleResponses.es.json</ProjectItem>
          <ProjectItem ReplaceParameters="true" TargetFileName="SampleResponses.fr.json">SampleResponses.fr.json</ProjectItem>
          <ProjectItem ReplaceParameters="true" TargetFileName="SampleResponses.it.json">SampleResponses.it.json</ProjectItem>
          <ProjectItem ReplaceParameters="true" TargetFileName="SampleResponses.zh.json">SampleResponses.zh.json</ProjectItem>
        </Folder>
        <Folder Name="Shared" TargetFolderName="Shared">
          <ProjectItem ReplaceParameters="false" TargetFileName="ResponseIdCollection.t4">ResponseIdCollection.t4</ProjectItem>
          <ProjectItem ReplaceParameters="true" TargetFileName="SharedResponses.tt">SharedResponses.tt</ProjectItem>
          <ProjectItem ReplaceParameters="true" TargetFileName="SharedResponses.cs">SharedResponses.cs</ProjectItem>
          <ProjectItem ReplaceParameters="true" TargetFileName="SharedResponses.json">SharedResponses.json</ProjectItem>
          <ProjectItem ReplaceParameters="true" TargetFileName="SharedResponses.de.json">SharedResponses.de.json</ProjectItem>
          <ProjectItem ReplaceParameters="true" TargetFileName="SharedResponses.es.json">SharedResponses.es.json</ProjectItem>
          <ProjectItem ReplaceParameters="true" TargetFileName="SharedResponses.fr.json">SharedResponses.fr.json</ProjectItem>
          <ProjectItem ReplaceParameters="true" TargetFileName="SharedResponses.it.json">SharedResponses.it.json</ProjectItem>
          <ProjectItem ReplaceParameters="true" TargetFileName="SharedResponses.zh.json">SharedResponses.zh.json</ProjectItem>
        </Folder>
      </Folder>
      <Folder Name="Services" TargetFolderName="Services">
        <ProjectItem ReplaceParameters="true" TargetFileName="BotServices.cs">BotServices.cs</ProjectItem>
        <ProjectItem ReplaceParameters="true" TargetFileName="BotSettings.cs">BotSettings.cs</ProjectItem>
        <ProjectItem ReplaceParameters="true" TargetFileName="$safeprojectname$Luis.cs">SkillLuis.cs</ProjectItem>
        <ProjectItem ReplaceParameters="true" TargetFileName="GeneralLuis.cs">GeneralLuis.cs</ProjectItem>
      </Folder>
      <ProjectItem ReplaceParameters="true" TargetFileName=".filenesting.json">.filenesting.json</ProjectItem>
      <ProjectItem ReplaceParameters="true" TargetFileName="appsettings.json">appsettings.json</ProjectItem>
      <ProjectItem ReplaceParameters="true" TargetFileName="cognitivemodels.json">cognitivemodels.json</ProjectItem>
      <ProjectItem ReplaceParameters="true" TargetFileName="manifestTemplate.json">manifestTemplate.json</ProjectItem>
      <ProjectItem ReplaceParameters="true" TargetFileName="Program.cs">Program.cs</ProjectItem>
      <ProjectItem ReplaceParameters="false" TargetFileName="readme.md">readme.md</ProjectItem>
      <ProjectItem ReplaceParameters="true" TargetFileName="Startup.cs">Startup.cs</ProjectItem>
    </Project>
  </TemplateContent>
</VSTemplate>