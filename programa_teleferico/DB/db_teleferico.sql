create database db_teleferico
use db_teleferico

drop database db_teleferico
 drop table tbl_p2
create table tbl_p1
(
 cd_fechamentop1 varchar(15) primary key not null,
 dt_fechammentop1 varchar(30) not null,
 nm_operadorp1 varchar(50) not null,
 vl_trocop1 int not null,
 no_bilhetep1_ida_ini1 int not null,
 no_bilhetep1_ida_final1 int not null,
 no_bilhetep1_ida_ini2 int,
 no_bilhetep1_ida_final2 int,
 no_bilhetep1_ida_ini3 int,
 no_bilhetep1_ida_final3 int,
 no_bilhetep1_volta_ini1 int not null,
 no_bilhetep1_volta_final1 int ,
 no_bilhetep1_volta_ini2 int not null,
 no_bilhetep1_volta_final2 int ,
 no_bilhetep1_volta_ini3 int not null,
 no_bilhetep1_volta_final3 int ,
 no_bilhetep1_PU_ini1 int not null,
 no_bilhetep1_PU_final1 int, 
 no_bilhetep1_PU_ini2 int,
 no_bilhetep1_PU_final int, 
 no_total_vendap1_ida int,
 no_total_dinheirop1_ida int,
 no_total_vendap1_volta int,
 no_total_dinheriop1_volta int,    
 no_total_vendap1_PU int,
 no_total_debitop1 int,
 no_total_creditop1 int,
 no_total_cartaop1 int,
 no_total_dinheirop1_vendas int,
 no_trouxep1 int,
 no_sangriap1 int,
 no_total_caixap1 int,
 ds_verificap1 varchar(60),
 ds_totalTrazer varchar(40),
 ds_totalTrouxe varchar(40)
)

drop table tbl_aberturap2

select cd_fechamentop1, dt_fechammentop1,vl_trocop1, no_total_vendap1_ida ,no_total_dinheirop1_ida,no_total_vendap1_volta ,no_total_dinheriop1_volta,ds_verificap1 from tbl_p1 where 

create table tbl_p2
(
cd_fechamentop2 varchar(15) not null,
dt_fechammentop2 varchar(30) not null,
nm_operadorp2 varchar(50) not null,
vl_trocop2 int not null,
no_bilhetep2_ida_ini1 int not null,
no_bilhetep2_ida_final1 int not null,
no_bilhetep2_ida_ini2 int,
no_bilhetep2_ida_final2 int,
no_bilhetep2_ida_ini3 int,
no_bilhetep2_ida_final3 int,
no_bilhetep2_volta_ini1 int not null,
no_bilhetep2_volta_final1 int not null,
no_bilhetep2_volta_ini2 int not null,
no_bilhetep2_volta_final2 int not null,
no_bilhetep2_volta_ini3 int not null,
no_bilhetep2_volta_final3 int not null,
no_bilhetep2_PU_ini1 int not null,
no_bilhetep2_PU_final1 int not null, 
no_bilhetep2_PU_ini2 int,
no_bilhetep2_PU_final int,
no_total_vendap2_ida int,
no_total_dinheirop2_ida int,
no_total_vendap2_volta int,
no_total_dinheriop2_volta int,
no_total_vendap2_PU int,
no_total_debitop2 int,
no_total_creditop2 int,
no_total_cartaop2 int,
no_total_dinheirop2_vendas int,
no_trouxep2 int,
no_sangriap2 int,
no_total_caixap2 int,
ds_verificap2 varchar(60),
 ds_totalTrazer varchar(40),
 ds_totalTrouxe varchar(40)
)
drop table tbl_aberturap2
create table tbl_aberturap1
(
cd_aberturap1 varchar(15) not null,
nm_operadorAberturap1 varchar(50) not null,
dt_fechamentoAberturap1 varchar(30) not null,
vl_trocoAberturap1 int not null,
no_bilheteAberturap1_ida_ini1 int not null,
no_bilheteAberturap1_ida_final1 int not null,
no_bilheteAberturap1_ida_ini2 int,
no_bilheteAberturap1_ida_final2 int,
no_bilheteAberturap1_ida_ini3 int,
no_bilheteAberturap1_ida_final3 int,
no_bilheteAberturap1_volta_ini1 int not null,
no_bilheteAberturap1_volta_final1 int not null,
no_bilheteAberturap1_volta_ini2 int not null,
no_bilheteAberturap1_volta_final2 int not null,
no_bilheteAberturap1_volta_ini3 int not null,
no_bilheteAberturap1_volta_final3 int not null,
no_bilheteAberturap1_PU_ini1 int not null,
no_bilheteAberturap1_PU_final1 int not null, 
no_bilheteAberturap1_PU_ini2 int,
no_bilheteAberturap1_PU_final int
)


create table tbl_aberturap2
(
cd_aberturap2 varchar(15) not null,
nm_operadorAberturap2 varchar(50) not null,
dt_fechamentoAberturap2 varchar(30) not null,
vl_trocoAberturap2 int not null,
no_bilheteAberturap2_ida_ini1 int not null,
no_bilheteAberturap2_ida_final1 int not null,
no_bilheteAberturap2_ida_ini2 int,
no_bilheteAberturap2_ida_final2 int,
no_bilheteAberturap2_ida_ini3 int,
no_bilheteAberturap2_ida_final3 int,
no_bilheteAberturap2_volta_ini1 int not null,
no_bilheteAberturap2_volta_final1 int not null,
no_bilheteAberturap2_volta_ini2 int not null,
no_bilheteAberturap2_volta_final2 int not null,
no_bilheteAberturap2_volta_ini3 int not null,
no_bilheteAberturap2_volta_final3 int not null,
no_bilheteAberturap2_PU_ini1 int not null,
no_bilheteAberturap2_PU_final1 int not null, 
no_bilheteAberturap2_PU_ini2 int,
no_bilheteAberturap2_PU_final int
)

select * from tbl_aberturaCatracap1
create table tbl_aberturaCatracap1
(
cd_aberturaCatracap1 varchar(15),
nm_nomeOperadorp1 varchar(15),
dt_dataAberturap1 varchar(15),
nm_inicialCatracap1 int
)

create table tbl_aberturaCatracap2
(
cd_aberturaCatracap2 varchar(15),
nm_nomeOperadorp2 varchar(15),
dt_dataAberturap1 varchar(15),
nm_inicialCatracap2 int
)

create table  tbl_fechamentoCatracap1
(
cd_fechamnetoCatracap1 varchar(15),
nm_operadorCatracap1 varchar(40),
dt_aberturaCatracap1 varchar(15),
no_inicialCatracap1 int,
no_finalCatracap1 int,
no_totalCatracap1 int,
no_totalIdaCatracap1 int,
no_totalVoltaCatracap1 int,
no_totalPUcatracap1 int,
no_totalCortesiap1 int,
ds_fechamentop1 varchar(50)
)



create table tbl_fechamentoCatracap2
(
cd_fechamnetoCatracap2 varchar(15),
nm_operadorCatracap2 varchar(40),
dt_aberturaCatracap2 varchar(15),
no_inicialCatracap2 int,
no_finalCatracap2 int,
no_totalCatracap2 int,
no_totalIdaCatracap2 int,
no_totalVoltaCatracap2 int,
no_totalPUcatracap2 int,
no_totalCortesiap1 int,
ds_fechamentop2 varchar(50)
)

create table tbl_login
(
nm_usuario varchar(20),
ds_senha varchar(20)
)

insert into tbl_login values('admin','admin');

create table tbl_bilhete
(
tipo_bilhete varchar(30),
qtde_bilhete int
)



create table tbl_atualiza
(
tipo_atualiza varchar (30),
qtde_atualiza int
)

SELECT cpf_func, nome_func FROM tbl_funcionario ORDER BY nome_func

create table tbl_funcionario
(
nome_func varchar(40),
cpf_func varchar(14),
celular_func varchar(16),
endereco_func varchar(50),
conta_func varchar(20),
agencia_func varchar(10),
cc_func varchar(15),
tipo_func varchar(20)
)


------------------------------------------------------------------------------------------------
create trigger tr_bilheteIda

--ocorrerá após um insert na tabela vendas
on tbl_p1 after insert

as begin
declare @vendaIda as int
declare @tipoBilhete as varchar(30)

--atribui o valor das variáveis
set @tipoBilhete = 'Ida/ Verde'
set @vendaIda =(select no_total_vendap1_ida from inserted)

update tbl_bilhete set tipo_bilhete=@tipoBilhete,qtde_bilhete = qtde_bilhete - @vendaIda where tipo_bilhete = @tipoBilhete

end

-----------------------------------------------------------------------------------------------
create trigger tr_bilheteVolta

--ocorrerá após um insert na tabela vendas
on tbl_p1 after insert

as begin
declare @vendaVolta as int
declare @tipoBilhete as varchar(30)

--atribui o valor das variáveis
set @tipoBilhete = 'Ida-Volta/ Verde'
set @vendaVolta =(select no_total_vendap1_volta from inserted)

update tbl_bilhete set tipo_bilhete=@tipoBilhete,qtde_bilhete = qtde_bilhete - @vendaVolta where tipo_bilhete = @tipoBilhete

end
-----------------------------------------------------------------------------------------------
create trigger tr_bilheteIda2

--ocorrerá após um insert na tabela vendas
on tbl_p2 after insert

as begin
declare @vendaIda as int
declare @tipoBilhete as varchar(30)

--atribui o valor das variáveis
set @tipoBilhete = 'Ida/ Vermelho'
set @vendaIda =(select no_total_vendap2_ida from inserted)

update tbl_bilhete set tipo_bilhete=@tipoBilhete,qtde_bilhete = qtde_bilhete - @vendaIda where tipo_bilhete = @tipoBilhete

end
-----------------------------------------------------------------------------------------------

create trigger tr_bilheteVolta2

--ocorrerá após um insert na tabela vendas
on tbl_p2 after insert

as begin
declare @vendaVolta as int
declare @tipoBilhete as varchar(30)

--atribui o valor das variáveis
set @tipoBilhete = 'Ida-Volta/ Vermelho'
set @vendaVolta =(select no_total_vendap2_volta from inserted)

update tbl_bilhete set tipo_bilhete=@tipoBilhete,qtde_bilhete = qtde_bilhete - @vendaVolta where tipo_bilhete = @tipoBilhete

end
----------------------------------------------------------------------------------------------
create trigger trAtualiza

on tbl_atualiza after insert
as begin
declare @bilhete as int
declare @bilheteNovo as int
declare @tipo as varchar(30)

set @tipo = (select tipo_atualiza from inserted)
set @bilheteNovo =(select qtde_atualiza from inserted)
set @bilhete =(select qtde_bilhete from tbl_bilhete where tipo_bilhete =@tipo)

update tbl_bilhete set tipo_bilhete=@tipo, qtde_bilhete=@bilhete+@bilheteNovo where tipo_bilhete= @tipo
end





select no_total_debitop2 , no_total_creditop2 , no_total_cartaop2 from tbl_p2 where dt_fechammentop2 >='31/10/2016' and dt_fechammentop2<='31/10/2016'