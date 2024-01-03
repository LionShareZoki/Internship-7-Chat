PGDMP      5                 |            Chat    16.1    16.1 G    k           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            l           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            m           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            n           1262    16761    Chat    DATABASE     h   CREATE DATABASE "Chat" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'C';
    DROP DATABASE "Chat";
                postgres    false            �            1259    16768    Captchas    TABLE     �   CREATE TABLE public."Captchas" (
    "CaptchaId" integer NOT NULL,
    "CaptchaString" text NOT NULL,
    "CreatedAt" timestamp with time zone NOT NULL
);
    DROP TABLE public."Captchas";
       public         heap    postgres    false            �            1259    16767    Captchas_CaptchaId_seq    SEQUENCE     �   ALTER TABLE public."Captchas" ALTER COLUMN "CaptchaId" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."Captchas_CaptchaId_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    217            �            1259    16820    ChannelMembers    TABLE     �   CREATE TABLE public."ChannelMembers" (
    "MembershipId" integer NOT NULL,
    "ChannelId" integer NOT NULL,
    "UserId" integer NOT NULL,
    "JoinedAt" timestamp with time zone NOT NULL
);
 $   DROP TABLE public."ChannelMembers";
       public         heap    postgres    false            �            1259    16819    ChannelMembers_MembershipId_seq    SEQUENCE     �   ALTER TABLE public."ChannelMembers" ALTER COLUMN "MembershipId" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."ChannelMembers_MembershipId_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    231            �            1259    16776    GroupChannels    TABLE     �   CREATE TABLE public."GroupChannels" (
    "ChannelId" integer NOT NULL,
    "ChannelName" text NOT NULL,
    "UserId" integer NOT NULL
);
 #   DROP TABLE public."GroupChannels";
       public         heap    postgres    false            �            1259    16775    GroupChannels_ChannelId_seq    SEQUENCE     �   ALTER TABLE public."GroupChannels" ALTER COLUMN "ChannelId" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."GroupChannels_ChannelId_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    219            �            1259    16836    Messages    TABLE     �   CREATE TABLE public."Messages" (
    "MessageId" integer NOT NULL,
    "SenderId" integer NOT NULL,
    "ChannelId" integer,
    "RecipientId" integer,
    "Content" text NOT NULL,
    "SentAt" timestamp with time zone NOT NULL
);
    DROP TABLE public."Messages";
       public         heap    postgres    false            �            1259    16835    Messages_MessageId_seq    SEQUENCE     �   ALTER TABLE public."Messages" ALTER COLUMN "MessageId" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."Messages_MessageId_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    233            �            1259    16784    ProfileSettings    TABLE     �   CREATE TABLE public."ProfileSettings" (
    "SettingId" integer NOT NULL,
    "UserId" integer NOT NULL,
    "SettingType" integer NOT NULL,
    "UpdatedAt" timestamp with time zone NOT NULL
);
 %   DROP TABLE public."ProfileSettings";
       public         heap    postgres    false            �            1259    16783    ProfileSettings_SettingId_seq    SEQUENCE     �   ALTER TABLE public."ProfileSettings" ALTER COLUMN "SettingId" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."ProfileSettings_SettingId_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    221            �            1259    16790 
   Statistics    TABLE     �   CREATE TABLE public."Statistics" (
    "StatisticId" integer NOT NULL,
    "TotalMessages" integer NOT NULL,
    "AverageMessagesPerUser" real NOT NULL,
    "AverageMessagesPerChannel" real NOT NULL,
    "TopUsers" integer[] NOT NULL
);
     DROP TABLE public."Statistics";
       public         heap    postgres    false            �            1259    16789    Statistics_StatisticId_seq    SEQUENCE     �   ALTER TABLE public."Statistics" ALTER COLUMN "StatisticId" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."Statistics_StatisticId_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    223            �            1259    16798    UserManagements    TABLE       CREATE TABLE public."UserManagements" (
    "ManagementId" integer NOT NULL,
    "AdminUserId" integer NOT NULL,
    "TargetUserId" integer NOT NULL,
    "ActionType" integer NOT NULL,
    "ActionDate" timestamp with time zone NOT NULL,
    "UserId" integer
);
 %   DROP TABLE public."UserManagements";
       public         heap    postgres    false            �            1259    16797     UserManagements_ManagementId_seq    SEQUENCE     �   ALTER TABLE public."UserManagements" ALTER COLUMN "ManagementId" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."UserManagements_ManagementId_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    225            �            1259    16812    UserSessions    TABLE     �   CREATE TABLE public."UserSessions" (
    "UserSessionId" integer NOT NULL,
    "UserId" integer NOT NULL,
    "SessionToken" text NOT NULL,
    "ExpiresAt" timestamp with time zone NOT NULL
);
 "   DROP TABLE public."UserSessions";
       public         heap    postgres    false            �            1259    16811    UserSessions_UserSessionId_seq    SEQUENCE     �   ALTER TABLE public."UserSessions" ALTER COLUMN "UserSessionId" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."UserSessions_UserSessionId_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    229            �            1259    16804    Users    TABLE       CREATE TABLE public."Users" (
    "UserId" integer NOT NULL,
    "Email" text NOT NULL,
    "isAdmin" boolean NOT NULL,
    "CreatedAt" timestamp with time zone NOT NULL,
    "UpdatedAt" timestamp with time zone NOT NULL,
    "Password" text DEFAULT ''::text NOT NULL
);
    DROP TABLE public."Users";
       public         heap    postgres    false            �            1259    16803    Users_UserId_seq    SEQUENCE     �   ALTER TABLE public."Users" ALTER COLUMN "UserId" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."Users_UserId_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    227            �            1259    16762    __EFMigrationsHistory    TABLE     �   CREATE TABLE public."__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL
);
 +   DROP TABLE public."__EFMigrationsHistory";
       public         heap    postgres    false            X          0    16768    Captchas 
   TABLE DATA           O   COPY public."Captchas" ("CaptchaId", "CaptchaString", "CreatedAt") FROM stdin;
    public          postgres    false    217   nZ       f          0    16820    ChannelMembers 
   TABLE DATA           ]   COPY public."ChannelMembers" ("MembershipId", "ChannelId", "UserId", "JoinedAt") FROM stdin;
    public          postgres    false    231   �Z       Z          0    16776    GroupChannels 
   TABLE DATA           O   COPY public."GroupChannels" ("ChannelId", "ChannelName", "UserId") FROM stdin;
    public          postgres    false    219   O[       h          0    16836    Messages 
   TABLE DATA           n   COPY public."Messages" ("MessageId", "SenderId", "ChannelId", "RecipientId", "Content", "SentAt") FROM stdin;
    public          postgres    false    233   �[       \          0    16784    ProfileSettings 
   TABLE DATA           ^   COPY public."ProfileSettings" ("SettingId", "UserId", "SettingType", "UpdatedAt") FROM stdin;
    public          postgres    false    221   �]       ^          0    16790 
   Statistics 
   TABLE DATA           �   COPY public."Statistics" ("StatisticId", "TotalMessages", "AverageMessagesPerUser", "AverageMessagesPerChannel", "TopUsers") FROM stdin;
    public          postgres    false    223   �]       `          0    16798    UserManagements 
   TABLE DATA           �   COPY public."UserManagements" ("ManagementId", "AdminUserId", "TargetUserId", "ActionType", "ActionDate", "UserId") FROM stdin;
    public          postgres    false    225   )^       d          0    16812    UserSessions 
   TABLE DATA           `   COPY public."UserSessions" ("UserSessionId", "UserId", "SessionToken", "ExpiresAt") FROM stdin;
    public          postgres    false    229   F^       b          0    16804    Users 
   TABLE DATA           e   COPY public."Users" ("UserId", "Email", "isAdmin", "CreatedAt", "UpdatedAt", "Password") FROM stdin;
    public          postgres    false    227   c^       V          0    16762    __EFMigrationsHistory 
   TABLE DATA           R   COPY public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") FROM stdin;
    public          postgres    false    215   �_       o           0    0    Captchas_CaptchaId_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public."Captchas_CaptchaId_seq"', 4, false);
          public          postgres    false    216            p           0    0    ChannelMembers_MembershipId_seq    SEQUENCE SET     O   SELECT pg_catalog.setval('public."ChannelMembers_MembershipId_seq"', 9, true);
          public          postgres    false    230            q           0    0    GroupChannels_ChannelId_seq    SEQUENCE SET     K   SELECT pg_catalog.setval('public."GroupChannels_ChannelId_seq"', 7, true);
          public          postgres    false    218            r           0    0    Messages_MessageId_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public."Messages_MessageId_seq"', 33, true);
          public          postgres    false    232            s           0    0    ProfileSettings_SettingId_seq    SEQUENCE SET     N   SELECT pg_catalog.setval('public."ProfileSettings_SettingId_seq"', 4, false);
          public          postgres    false    220            t           0    0    Statistics_StatisticId_seq    SEQUENCE SET     K   SELECT pg_catalog.setval('public."Statistics_StatisticId_seq"', 2, false);
          public          postgres    false    222            u           0    0     UserManagements_ManagementId_seq    SEQUENCE SET     Q   SELECT pg_catalog.setval('public."UserManagements_ManagementId_seq"', 4, false);
          public          postgres    false    224            v           0    0    UserSessions_UserSessionId_seq    SEQUENCE SET     O   SELECT pg_catalog.setval('public."UserSessions_UserSessionId_seq"', 4, false);
          public          postgres    false    228            w           0    0    Users_UserId_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public."Users_UserId_seq"', 6, true);
          public          postgres    false    226            �           2606    16774    Captchas PK_Captchas 
   CONSTRAINT     _   ALTER TABLE ONLY public."Captchas"
    ADD CONSTRAINT "PK_Captchas" PRIMARY KEY ("CaptchaId");
 B   ALTER TABLE ONLY public."Captchas" DROP CONSTRAINT "PK_Captchas";
       public            postgres    false    217            �           2606    16824     ChannelMembers PK_ChannelMembers 
   CONSTRAINT     n   ALTER TABLE ONLY public."ChannelMembers"
    ADD CONSTRAINT "PK_ChannelMembers" PRIMARY KEY ("MembershipId");
 N   ALTER TABLE ONLY public."ChannelMembers" DROP CONSTRAINT "PK_ChannelMembers";
       public            postgres    false    231            �           2606    16782    GroupChannels PK_GroupChannels 
   CONSTRAINT     i   ALTER TABLE ONLY public."GroupChannels"
    ADD CONSTRAINT "PK_GroupChannels" PRIMARY KEY ("ChannelId");
 L   ALTER TABLE ONLY public."GroupChannels" DROP CONSTRAINT "PK_GroupChannels";
       public            postgres    false    219            �           2606    16842    Messages PK_Messages 
   CONSTRAINT     _   ALTER TABLE ONLY public."Messages"
    ADD CONSTRAINT "PK_Messages" PRIMARY KEY ("MessageId");
 B   ALTER TABLE ONLY public."Messages" DROP CONSTRAINT "PK_Messages";
       public            postgres    false    233            �           2606    16788 "   ProfileSettings PK_ProfileSettings 
   CONSTRAINT     m   ALTER TABLE ONLY public."ProfileSettings"
    ADD CONSTRAINT "PK_ProfileSettings" PRIMARY KEY ("SettingId");
 P   ALTER TABLE ONLY public."ProfileSettings" DROP CONSTRAINT "PK_ProfileSettings";
       public            postgres    false    221            �           2606    16796    Statistics PK_Statistics 
   CONSTRAINT     e   ALTER TABLE ONLY public."Statistics"
    ADD CONSTRAINT "PK_Statistics" PRIMARY KEY ("StatisticId");
 F   ALTER TABLE ONLY public."Statistics" DROP CONSTRAINT "PK_Statistics";
       public            postgres    false    223            �           2606    16802 "   UserManagements PK_UserManagements 
   CONSTRAINT     p   ALTER TABLE ONLY public."UserManagements"
    ADD CONSTRAINT "PK_UserManagements" PRIMARY KEY ("ManagementId");
 P   ALTER TABLE ONLY public."UserManagements" DROP CONSTRAINT "PK_UserManagements";
       public            postgres    false    225            �           2606    16818    UserSessions PK_UserSessions 
   CONSTRAINT     k   ALTER TABLE ONLY public."UserSessions"
    ADD CONSTRAINT "PK_UserSessions" PRIMARY KEY ("UserSessionId");
 J   ALTER TABLE ONLY public."UserSessions" DROP CONSTRAINT "PK_UserSessions";
       public            postgres    false    229            �           2606    16810    Users PK_Users 
   CONSTRAINT     V   ALTER TABLE ONLY public."Users"
    ADD CONSTRAINT "PK_Users" PRIMARY KEY ("UserId");
 <   ALTER TABLE ONLY public."Users" DROP CONSTRAINT "PK_Users";
       public            postgres    false    227            �           2606    16766 .   __EFMigrationsHistory PK___EFMigrationsHistory 
   CONSTRAINT     {   ALTER TABLE ONLY public."__EFMigrationsHistory"
    ADD CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId");
 \   ALTER TABLE ONLY public."__EFMigrationsHistory" DROP CONSTRAINT "PK___EFMigrationsHistory";
       public            postgres    false    215            �           1259    16853    IX_ChannelMembers_ChannelId    INDEX     a   CREATE INDEX "IX_ChannelMembers_ChannelId" ON public."ChannelMembers" USING btree ("ChannelId");
 1   DROP INDEX public."IX_ChannelMembers_ChannelId";
       public            postgres    false    231            �           1259    16854    IX_ChannelMembers_UserId    INDEX     [   CREATE INDEX "IX_ChannelMembers_UserId" ON public."ChannelMembers" USING btree ("UserId");
 .   DROP INDEX public."IX_ChannelMembers_UserId";
       public            postgres    false    231            �           1259    16855    IX_Messages_ChannelId    INDEX     U   CREATE INDEX "IX_Messages_ChannelId" ON public."Messages" USING btree ("ChannelId");
 +   DROP INDEX public."IX_Messages_ChannelId";
       public            postgres    false    233            �           1259    16856    IX_Messages_SenderId    INDEX     S   CREATE INDEX "IX_Messages_SenderId" ON public."Messages" USING btree ("SenderId");
 *   DROP INDEX public."IX_Messages_SenderId";
       public            postgres    false    233            �           1259    16862    IX_ProfileSettings_UserId    INDEX     ]   CREATE INDEX "IX_ProfileSettings_UserId" ON public."ProfileSettings" USING btree ("UserId");
 /   DROP INDEX public."IX_ProfileSettings_UserId";
       public            postgres    false    221            �           1259    16859    IX_UserManagements_AdminUserId    INDEX     g   CREATE INDEX "IX_UserManagements_AdminUserId" ON public."UserManagements" USING btree ("AdminUserId");
 4   DROP INDEX public."IX_UserManagements_AdminUserId";
       public            postgres    false    225            �           1259    16860    IX_UserManagements_TargetUserId    INDEX     i   CREATE INDEX "IX_UserManagements_TargetUserId" ON public."UserManagements" USING btree ("TargetUserId");
 5   DROP INDEX public."IX_UserManagements_TargetUserId";
       public            postgres    false    225            �           1259    16861    IX_UserManagements_UserId    INDEX     ]   CREATE INDEX "IX_UserManagements_UserId" ON public."UserManagements" USING btree ("UserId");
 /   DROP INDEX public."IX_UserManagements_UserId";
       public            postgres    false    225            �           1259    16858    IX_UserSessions_UserId    INDEX     W   CREATE INDEX "IX_UserSessions_UserId" ON public."UserSessions" USING btree ("UserId");
 ,   DROP INDEX public."IX_UserSessions_UserId";
       public            postgres    false    229            �           1259    16857    IX_Users_Email    INDEX     N   CREATE UNIQUE INDEX "IX_Users_Email" ON public."Users" USING btree ("Email");
 $   DROP INDEX public."IX_Users_Email";
       public            postgres    false    227            �           2606    16825 8   ChannelMembers FK_ChannelMembers_GroupChannels_ChannelId    FK CONSTRAINT     �   ALTER TABLE ONLY public."ChannelMembers"
    ADD CONSTRAINT "FK_ChannelMembers_GroupChannels_ChannelId" FOREIGN KEY ("ChannelId") REFERENCES public."GroupChannels"("ChannelId") ON DELETE CASCADE;
 f   ALTER TABLE ONLY public."ChannelMembers" DROP CONSTRAINT "FK_ChannelMembers_GroupChannels_ChannelId";
       public          postgres    false    219    231    3493            �           2606    16830 -   ChannelMembers FK_ChannelMembers_Users_UserId    FK CONSTRAINT     �   ALTER TABLE ONLY public."ChannelMembers"
    ADD CONSTRAINT "FK_ChannelMembers_Users_UserId" FOREIGN KEY ("UserId") REFERENCES public."Users"("UserId") ON DELETE CASCADE;
 [   ALTER TABLE ONLY public."ChannelMembers" DROP CONSTRAINT "FK_ChannelMembers_Users_UserId";
       public          postgres    false    227    231    3506            �           2606    16889 ,   Messages FK_Messages_GroupChannels_ChannelId    FK CONSTRAINT     �   ALTER TABLE ONLY public."Messages"
    ADD CONSTRAINT "FK_Messages_GroupChannels_ChannelId" FOREIGN KEY ("ChannelId") REFERENCES public."GroupChannels"("ChannelId");
 Z   ALTER TABLE ONLY public."Messages" DROP CONSTRAINT "FK_Messages_GroupChannels_ChannelId";
       public          postgres    false    233    219    3493            �           2606    16848 #   Messages FK_Messages_Users_SenderId    FK CONSTRAINT     �   ALTER TABLE ONLY public."Messages"
    ADD CONSTRAINT "FK_Messages_Users_SenderId" FOREIGN KEY ("SenderId") REFERENCES public."Users"("UserId") ON DELETE CASCADE;
 Q   ALTER TABLE ONLY public."Messages" DROP CONSTRAINT "FK_Messages_Users_SenderId";
       public          postgres    false    227    3506    233            �           2606    16863 /   ProfileSettings FK_ProfileSettings_Users_UserId    FK CONSTRAINT     �   ALTER TABLE ONLY public."ProfileSettings"
    ADD CONSTRAINT "FK_ProfileSettings_Users_UserId" FOREIGN KEY ("UserId") REFERENCES public."Users"("UserId") ON DELETE CASCADE;
 ]   ALTER TABLE ONLY public."ProfileSettings" DROP CONSTRAINT "FK_ProfileSettings_Users_UserId";
       public          postgres    false    221    227    3506            �           2606    16868 4   UserManagements FK_UserManagements_Users_AdminUserId    FK CONSTRAINT     �   ALTER TABLE ONLY public."UserManagements"
    ADD CONSTRAINT "FK_UserManagements_Users_AdminUserId" FOREIGN KEY ("AdminUserId") REFERENCES public."Users"("UserId") ON DELETE CASCADE;
 b   ALTER TABLE ONLY public."UserManagements" DROP CONSTRAINT "FK_UserManagements_Users_AdminUserId";
       public          postgres    false    3506    225    227            �           2606    16873 5   UserManagements FK_UserManagements_Users_TargetUserId    FK CONSTRAINT     �   ALTER TABLE ONLY public."UserManagements"
    ADD CONSTRAINT "FK_UserManagements_Users_TargetUserId" FOREIGN KEY ("TargetUserId") REFERENCES public."Users"("UserId") ON DELETE CASCADE;
 c   ALTER TABLE ONLY public."UserManagements" DROP CONSTRAINT "FK_UserManagements_Users_TargetUserId";
       public          postgres    false    225    3506    227            �           2606    16878 /   UserManagements FK_UserManagements_Users_UserId    FK CONSTRAINT     �   ALTER TABLE ONLY public."UserManagements"
    ADD CONSTRAINT "FK_UserManagements_Users_UserId" FOREIGN KEY ("UserId") REFERENCES public."Users"("UserId");
 ]   ALTER TABLE ONLY public."UserManagements" DROP CONSTRAINT "FK_UserManagements_Users_UserId";
       public          postgres    false    225    227    3506            �           2606    16883 )   UserSessions FK_UserSessions_Users_UserId    FK CONSTRAINT     �   ALTER TABLE ONLY public."UserSessions"
    ADD CONSTRAINT "FK_UserSessions_Users_UserId" FOREIGN KEY ("UserId") REFERENCES public."Users"("UserId") ON DELETE CASCADE;
 W   ALTER TABLE ONLY public."UserSessions" DROP CONSTRAINT "FK_UserSessions_Users_UserId";
       public          postgres    false    227    229    3506            X   H   x�3�ttr642�4202�54�56P0��22�24�337556�60�2⌈�2��$�̘30���Ԍ��=... �\#      f   y   x�mλ�0�Z�B}��}u�Y���\0�_Amڬ1�L��9X
y�)(>Hݶ����U���z�j'��D�(��,�Rю��KD��`,����&D���M6�5Q��i~���/��&�      Z   a   x�3�tO�K-J��4�2�J�K���4�2�.-(�/*�4�2�t�,*.q�H��K��4�2��K-W �d����KinA~Yr&�c���t�K��qqq f�      h   	  x�}��n�@@k�+���k��m� ���X1"�lG���I9�d���f�"e%z�j;<t���+�҆��XC�(>���Òw;w�v����iqҞ����\ҩW����������d��-9{�����'����;^������4�����۠u�������@��ĩXf��<�=�-6�����8�׭U�O�lk-�$,��'�b�����a	�LfiL���?���s�/���.�R	+��Xd:!���j���m�s�����X@�����`*E�tH���Te	J1���i����1X�3���_���k�tJ!!g��<b[�,�L,}����I�d{Bm8��m�#�͆���;��4��p��%��3�6O�.�C�/V/YJBc㙽��Y�)��2�*��ݫP��Ԉb���Hef5�>�>���2��QGR��(���0�}�k�2V`_�^�?�U�[ٟ㚺!����NAbK�d���
�X�6sf%��.P�
�)���{�^���:W      \      x������ � �      ^   #   x�3�440 b=SN#=c�jC#�Z�=... JR      `      x������ � �      d      x������ � �      b   F  x����j[1F��Sx_|����U���ch]�$�f���M�,
���>���^��������ͷ���s�}��~���HG��*��/P�Ծ �'��n���3��e�N�D�\K��GjdJT�Q�@c�y*!Y�:t6��Kem�,3�]��6{۝ﮗ���������7����UlU]BD��`�#M�
#�2��%�X�=:��l8���:�=6@u�IHx1���s��o��E�~`������q?`��+�"���/㟦�y��rf�m7B��aB�"�v�Q��pnf�=�S�ӷr'n��1�D
���[��D�_��~�
;      V   �   x�e�A
�0е9�'(I�5�R*����	a �j#��׷h������h�A��V `�n9`�$�L[�B
�!�**��7?v�������z�!<WF����[{�"�3&�S�eV�`]�~v ��83 ��R�����ۘ�c�\0O�S!�xo�@�     