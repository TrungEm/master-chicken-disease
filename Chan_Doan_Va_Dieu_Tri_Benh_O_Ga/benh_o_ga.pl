%  triệu chứng

symptoms(1, u_ru).
symptoms(2, uong_nhieu_nuoc).
symptoms(3, luoi_di_lai).
symptoms(4, long_xu).
symptoms(5, sot_cao).
symptoms(6, bo_an).
symptoms(7, tieu_chay_phan_trang).
symptoms(8, mau_tham_tim).
symptoms(9, cham_lon).
symptoms(10, thieu_mau_mao_nhot).
symptoms(11, met_moi).
symptoms(12, mat_lim_dim).
symptoms(13, tho_kho).
symptoms(14, chay_nhieu_nuoc_mui).
symptoms(15, ia_phan_trang_va_phan_co_nhieu_chat_nhay).
symptoms(16, noi_nhieu_mun_mu).
symptoms(17, trong_cam_ga_co_thanh_phan_muoi_cao).

% Xây dựng tập luật bệnh tương ứng với từng triệu chứng cụ thể

disease(cau_trung, [1, 2, 3, 4]).
disease(tieu_chay, [1, 5, 6, 7]).
disease(cum_gia_cam, [2, 5, 8]).
disease(giun_dua, [6, 9, 10]).
disease(nam_phoi, [6, 11, 12, 13, 14]).
disease(thuong_han_ga, [15]).
disease(dau_ga, [16]).
disease(trung_doc_muoi_an, [17]).

%new rule

contained_in(L1, L2) :- maplist(contains(L2), L1).

contains(L, X) :- member(X, L).

check_elements([], _) :-
    false.

check_elements([X|_], List) :-
    member(X, List),
    true.

check_elements([_|Xs], List) :-
    check_elements(Xs, List).

disease_symptoms(X, Y, Z) :-  disease(X, Z), contained_in(Y, Z).

not_disease_symptoms(X, Y, Z) :-  disease(X, Z),not( contained_in(Y, Z)).

disease(A, B, C, D) :- disease(A, D), contained_in(B,D), not(check_elements(C,D)).

