# Sobre o programa - Como testá-lo

1) O programa se propõe em cadastrar ESPORTISTAS, uma entidade herdada de PESSOAS, que herda de BASEMODEL.
2) Para cadastrar, basicamente preencha um GUID (pode ser criado pelo botão 'Gerar GUID randômico'), e prencher dados de Nome, Peso, Altura. Pode ser marcado o flag caso ele pratica esportes e informar esta frequência.
3) Ao término da digitação, clique em INCLUIR/SALVAR. O registro será apresentado na GRID.
4) Para editar o registro, basta clicar no registro da grid e clicar em EDITAR.
5) É possível também CONSULTAR a partir de um GUID, e feito isso, ele ficará passível de edição.
6) Caso tenha editado um registro cujo GUID exista, e clicar em INCLUIR/SALVAR, este registro será alterado, não incluído um novo.
7) Todos os dados são salvos em um arquivo JSON, que é criado dinamicamente caso não exista, no mesmo nível do EXE.
BONUS: é posível cadastrar 5 registros aleatórios, caso clicar em 'GERAR DADOS'.

# Informações sobre o código
1) Arquitetura dividida em 3 projetos
2) Utiliza orientação a objetos
3) Utiliza herança
4) Possui 3 validações ao salvar ou editar, bem como 1 cálculo de IMC.
