﻿using System;

namespace Formal_Languages_And_Automata
{
    public class Properties_Of_Context_Free_Languages
    {
        //public enum Pumping Lemma For Context Free Languages Properties {To express pumping lemma for context-free languages we present this theorem.Theorem: let L be an infinite context free language then there exists some positive integer m such that any w element of L with |w| >= m can be decomposed as w = uvxyz with |vxy| <= m and |vy| >= 1 such that wv^(i)xy^(i)z is an element of L for all i = 1,2,... etc this is known as the pumping lemma for context free languages,To prove it we have that consider language L-{Lambda} and assume we have a grammar G without unit-productions and lambda productions for it then since length of string on right side of any production is bounded say by k , then length of derivation of any win L must be at least /w//k there for since L is infinite we have arbitrary long derivations and corresponding trees of arbitrary height consider one of those high derivation trees and some efficiently long paths from roat to leaf since number of variables in G is finite we have a variable that repeats on this path corresponding to the derivation tree we have derivation:S-*>uAz -*>uvAyz-*>uvxyz where u,v,x,y,and z are all strings of terminal so we have that A=*>vAy and A=*>x ,So all the strings uvixyiz ,c=0,1,z,… can be generated by the grammar and are there five in L. also we can assume that in derivations A -*>vAy and A-*>x we can assume that no variable repeats since in leaf of tree if variable repeats we just apply the argument in this repeating variable in not leaf parts of tree since corresponding string in deviations (uv^(i)xy^(i),v and y) their lengths only depend on productions and can be bounded independently of w (holding |vxy|<=m) and since we don’t have unit and lambda productions v and y can be both empty string (holding |vy|>=1),>>>>its used negatively to show that a given language does not belong to context free languges family,the correct argument can be visualized as a game against an intelligent opponent But rules make it a little more difficult for us,for regular languages substring xy which its length is bounded by m starts at left end of w so substring y that can be pumped is within m symbols of beginning of w.but for context free languages we only have a bound on |vxy| the substring u that precedes vxy can be arbitrarily long this gives additional freedom to the adverary making argument a little more complicated };
        //public enum Linear Context Free Language Properties { a context free language L is said to be linear if there exists a linear context free grammar G for it such that L=L(G),>>>>Just because a specific grammar isn’t linear doesn’t imply that the language generated by it isn’t linear,if we want to prove that a language is not linear we must show that there exit no equivalent linear grammar we approach this in the usual way establishing structural properties for linear languages then showing that some context free languages dont have a required property,>>>>It’s expressed by this theorem which is said pumping lemma for linear language,let L be an infinite linear language then there exists some positive integer m such that any w element of L with |w| >= m can be  decomposed as w = uvxyz with |uvyz| <= m |vy| >= 1 such that uv^(i)xy^(i)z is an element of L for all i = 0,1,2,... and strings v and y to be pumped must now be located within m symbols of the left and right ends of w respectively the middle string x can be of arbitrary length,To prove it we have that since the language is linear we have a linear grammar G for it ,we also assume that G has no unit-productions and Lambda-productions since removing them does not destroy the linearity of the grammar, now consider derivation of a string w in L(G) : s-*>uAz-*>uvAyz-*>uvxyz=w now assume for every w in L(G)we have a variable A such that 1)In the partial derivation s -*>uAz no variable is repeated2)in the partial derivation s-*>uAz-*>uvAyz no variable except A is repeated3)the repetition of A must occur in the first m steps where m can depend on the grammar but not on w,so if its true then the lengths of u,v,y,z must be bounded independent of w so this implies that |u v y z| ≤m,|vy|≥1 and uvixyiz in L must hold to complete the argument we must demonstrate that these conditions hold for every linear grammar we do this by looking at sequences in which the variable can occar ,but now when we want to use this theorem we present a decomposition w then present some is in formula if we can find some string in this way not in L then we see that L isn’t linear by using this theorem we can conclude that the family of linear languages is a paper subset of the family of context-free language.,>>>>if G be a linear grammar with k variables when we write any sequence of variables there must be some variable A that repeats so that 1)the first occurrence of A must be in position p <= k ,2)the repetition of A must be no later than q <=k+1 and  3)there can be no other repeating variable between positions p and q};
        //public enum Context Free Language Closure Properties { When we want to see closure under certain operations and algorithms on context-free languages we encounter difficulties first closure properties thta hold for regular languages do not always hold for context free languages when they do the arguments needed to prove them are often quite complicated second many intuitively simple and important questions about context free languages cannot be answered   So now we present samples of some of must important results by these theorems:theorem:the family of context free language is closed under union concatenation, and star-closure to prove it we have that let L1and L2 be two content-free languages generated by grammars G1=(V1,T1,S1,P1) and G2=(V2,T2,S2,P2) assuming that V1 and V2 are disjoint consider the language L(G3)=L1UL2 generated by the grammar G3=(V1 U V2 U {S3},T1 U T2,S3,P3) where S3 is a variable not in V1 U V2 , the productions of G3 are all the productions of G1 and G2 together with an alternative starting production that allows us to use one or other grammars ,more precisely p3=p1Up2U{S3->S1/S2},since G3 is a context-free grammar so L(G3) is a context-free language , now suppose that w is in L1 then we have S3 -> S1 -*>w for G3 also if w is in L2 then we have S3-> S2-*>w , then if w is in L(G3) then we have either S3 -> S1 or S3-> S2 for first step of derivation if we use S3 -> S1 then since sentential forms derived from S1 have variables in V1 an V1 and V2 are disjoint then the derivation S1-*>w have productions in P1 only hence w must be in L1 also if S3-> S2 is used then w will be in L2 so we conclude that L(G3) is the union of L1 and L2 next consider G4=( V1 U V2 U{S4}, T1 U T2,S4,P4) with S4 a new variable and P4=P1 U P2 U {S4->S1S2} then L(G4)=L(G1)L(G2) finally consider L(G5) with G5=(V1U{S5},T1,S5,P5) with S5 a new variable and P5=P1 U {S5->S1 S5/Lambda} then L(G5)= L(G1)* so theorem is proved,Theorom:the family of context-free languages is not closed under intersection and complementation to prove it we have that for intersection we we an example language to reach contradiction e.g. we have that L1={an bn cm :n≥0,m≥0}and L2={an bm cm n≥0,m≥0} are context-free but L1W L2={ an bn cm n≥0} isn’t context-free so the family of context-free languages isn’t closed under intersection, for complementation we now we have that L1W L2=(( L1')U(L2')) if the family of context-free languages were closed under complementation then the right side of above expression will be context-free for any context-free L1 and L2 but this contradicts with theorem that intersection of two context-free languages isn’t necessarily context-free so the family of context-free languages isn’t closed under complementation.,>>>> if L1 be a context free language and L2 be a regular language then L1 intersection L2 is context free  So the closure property holds as expressed by this theorem theorem:let L1 be a context-free language and L2 be a regular language then L1W L2 is context-free and presented as it algorithm , this property is called closure under regular intersection so the family of context-free languages is closed under regular intersection.,>>>>we can establish the existence of some algorithms for context-free languages as expressed by these theorems .Theorem: given a context-free grammar G=(V,T,S,P) there exists an algorithm for deciding whether or not L(G) is empty to prove it we have that for simplicity we assume that Lambda isn’t in L(G) we need slight changes if it’s so we use the algorithm for removing useless symbols and productions,this closure property is sometimes useful for simplifying arguments in connection with specific languages. If S is found to be useless then L(G) is empty if not then L(G) contains at least one element Theorem : given a context-free grammar G=(V,T,S,F) there exists an algorithm for determining whether or not L(G) is infinite to prove it we have that we assume G has no Lambda-production, no unit-production and no useless symbols.Suppose grammar has a reapiting variable meaning that we have some A in V for which there is a derivation A-*>xAy Since G doesn’t have any Lambda-production and unit productions u and y cant be simultaneously empty and since A is neither nullable or useless symbol we have s-*>uAv->w and A->z Where u,v and z are in T* but then s-*>uAv -*>uxAyv->auzyv is possible for all n so that L(G) is infinite but if no variable can ever repeat then the length of any derivation is bounded by |V| and L(G) is finite so to get an algorithm for determining whether L(G) is finite we need only to determine whether the grammar has some repeating variables this can be done by drawing a dependency graph for variables so that it has on edge(A,B)whenever there is a corresponding production A->xBy then any variable at the base of a cycle is a repeating one consequently the grammar has a repeating variable iff the dependency graph has a repeating variable iff the dependency graph has a cycle since we now have an algorithm for deciding whether a grammar has a repeating variable we have an algorithm for determining whether or not L(G) is infinite . Also these algorithms also exist for contact-free language for any given content-free grammar G we can determine whether or not Lambda is in L(G),theorem: there exists an algorithm to determine whether the language generated by some context-free grammar contains any words of length less than some given number n ,theorem: let L1 be a context-free language and L2 be regular then there exists an algorithm to determine whether or not L2 have a common element.,>>>>also these colsure properties hold for cotext-free laguages context free languges is closed under homomorphism,linear languages is closed under homomorphism,context free languges is closed under reserval,context free languges is not closed under difference but is closed under regular difference that is if L1 is context-free and L2 is regular then L1 - L2 is context-free,linear languages is closed under union but not closed under concatenation and intersection,if L1 is linear and L2 is regular then L1L2 is a linear language,unambiguous context free languages is not closed union and intersection};
        //publice enum Regular Intersection Algorithm Properties{ its expressed by this theorem Theorem:let L1 be a context-free language and L2 be a regular language then L1W L2 is context-free to prove it we have that let M1=(Q,ZIGMA,GAMMA,zigma1,q0,z,F1) be an npda accepting L1 and M2=(p,ZIGMA,zigma2,p0,F2) be adfa accepting L2.we construct a pushdown automation M^(Q^, ZIGMA,GAMMA,zigma^,q0^,z,F) simulating the parallel action of M1 and M2 so that when a symbol is read from input string , M^ simultaneously executes the moves of M1 and M2 now we let Q^=Q * P ,q0=(q0,p0) and q^0=(q0,p0), F^=F1*F2 and define zigma^ so that ((qk,QL),x) is in zigma^((qi,pj),a,b) iff (qk,x) is in zigma1(qi,a,b) and zigma2(pj,a)= Pl,in this we also require that if a=Lambda then pj=pL in other words states of M^ are labled with pairs (qi,qj) representing respective states in which M1 and M2 can be after reading a certain input symbol it’s a straightforward argument to show that ((q0,p0),w,z)|-m* ((qr,ps),Lambda,n) with qr in F1 and ps in F2 iff (q0,w,z) |-m* (q1,Lambda,x) and zigma*(q0,w)=ps so string is accepted by U^ iff its accepted by M1 and M2 so if its in L(M1)W L(M2)=L1WL2 this property is called regular intersection.
    }
}
