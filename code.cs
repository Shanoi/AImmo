    <Window.Resources>

        <ObjectDataProvider x:Key="TransactionTypesProvider"
                            MethodName="GetValues"
                            ObjectType="{x:Type sys:Enum}"
                            <ObjectDataProvider.MethodParameters>
            <x:TypeExtension TypeName="s:BienImmobilierBase+eTypeTransaction"/>
            </ObjectDataProvider.MethodParameters>

    </Window.Resources>