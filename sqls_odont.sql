CREATE DATABASE odont;
use odont;




CREATE TABLE dentista (
iddentista int not null auto_increment PRIMARY KEY,
cpf int,
rg int,
orgao_expedidor varchar(40),
nome varchar(60),
cro varchar(15),
login varchar(40),
senha varchar(40),
tipo varchar(20),
endereco varchar(40),
telefone int


)engine=InnoDb;

CREATE TABLE expediente(
dentista int not null,

segunda_matutino_ent datetime,
segunda_matutino_sai datetime,

segunda_vespertino_ent datetime,
segunda_vespertino_sai datetime,

segunda_noturno_ent datetime,
segunda_noturno_sai datetime,

terca_matutino_ent datetime,
terca_matutino_sai datetime,

terca_vespertino_ent datetime,
terca_vespertino_sai datetime,

terca_noturno_ent datetime,
terca_noturno_sai datetime,

quarta_matutino_ent datetime,
quarta_matutino_sai datetime,

quarta_vespertino_ent datetime,
quarta_vespertino_sai datetime,

quarta_noturno_ent datetime,
quarta_noturno_sai datetime,

quinta_matutino_ent datetime,
quinta_matutino_sai datetime,

quinta_vespertino_ent datetime,
quinta_vespertino_sai datetime,

quinta_noturno_ent datetime,
quinta_noturno_sai datetime,

sexta_matutino_ent datetime,
sexta_matutino_sai datetime,

sexta_vespertino_ent datetime,
sexta_vespertino_sai datetime,

sexta_noturno_ent datetime,
sexta_noturno_sai datetime,
FOREIGN KEY (dentista) references dentista(iddentista) on delete restrict
);

CREATE TABLE paciente (
idpaciente int not null auto_increment PRIMARY KEY,
estado_civil varchar(15),
orgao_expedidor varchar(40),
sexo varchar(15),
nome varchar(60),
rg varchar(15),
naturalidade varchar(30),
cpf varchar(15),
profissao varchar(30),
nacionalidade varchar(15),
data_de_nascimento date,
endereco_profissional varchar(140),
endereco_residencial varchar(140),
curso varchar(50)

)engine=InnoDb;

CREATE TABLE consulta(
idconsulta int not null auto_increment PRIMARY KEY,
hora datetime,
data date,
procedimeto varchar(300),
prev_duracao int,
status int,
dentista int not null,
paciente int not null,
FOREIGN KEY (dentista) references dentista(iddentista) on delete restrict,
FOREIGN KEY (paciente) references paciente(idpaciente) on delete restrict
)engine=InnoDb;

CREATE TABLE ficha_clinica (
idficha_clinica int not null auto_increment PRIMARY KEY,
extra_oral varchar(300),
intra_oral varchar(300),
geral varchar(300),
Plano varchar(300),
id_dentista int not null,
id_paciente int not null,
status_tratamento int,
FOREIGN KEY(id_dentista) REFERENCES dentista(iddentista) on delete restrict,
FOREIGN KEY(id_paciente) REFERENCES paciente(idpaciente) on delete restrict
)engine=InnoDb;

CREATE TABLE anamnese (
idficha_clinica int not null PRIMARY KEY,
data date,
local varchar(20),
queixa_principal varchar(500),
sofre_doenca int,sofre_doenca_quais varchar(200),
esta_em_tratamento int,
gravidez int,
usa_medicacao int,usa_medicacao_quais varchar(200),usa_medicacao_medico varchar(200),
alergia int,alergia_quais varchar(200),
operado int,operado_quais varchar(200),operado_cicatrizacao int,operado_anestezia int,operado_hemorragia int,
febre_reumatica int,
cardiacos int,
renais int,
gastricos int,
respiratorios int,
alergicos int,
articulares int,
diabetes int,
hipertencao int,
habitos varchar(300),
ante_familiares varchar(300),
observacoes varchar(300),
FOREIGN KEY(idficha_clinica) REFERENCES ficha_clinica(idficha_clinica) on delete restrict
)engine=InnoDb;

CREATE TABLE dente (
descricao varchar(300),
idficha_clinica int not null,
iddente int not null,
FOREIGN KEY(idficha_clinica) REFERENCES ficha_clinica(idficha_clinica) on delete restrict,
primary key(iddente,idficha_clinica)
)engine=InnoDb;

CREATE TABLE faces (
id_face int not null,
cor varchar(40),
idficha_clinica int not null,
iddente int not null,
FOREIGN KEY(idficha_clinica) REFERENCES ficha_clinica(idficha_clinica) on delete restrict,
FOREIGN KEY(iddente) REFERENCES dente(iddente),

primary key(idficha_clinica,iddente,id_face)
)engine=InnoDb;


