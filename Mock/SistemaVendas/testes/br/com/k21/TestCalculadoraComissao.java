package br.com.k21;

import static org.junit.Assert.assertEquals;
import org.junit.Test;

public class TestCalculadoraComissao {

	@Test
	public void teste_calculo_comissao_venda_500_retorna_25() {

		int venda = 500;
		int esperado = 25;

		double comissao = CalculadoraComissao.calcular(venda);

		assertEquals(esperado, comissao, 0);
	}

	@Test
	public void teste_calculo_comissao_venda_500000_retorna_3000() {
		int venda = 50000;
		int esperado = 3000;

		double comissao = CalculadoraComissao.calcular(venda);

		assertEquals(esperado, comissao, 0);
	}
	
	@Test
	public void teste_calculo_comissao_venda_10001_retorna_600ponto06() {
		double venda = 10001;
		double esperado = 600.06;

		double comissao = CalculadoraComissao.calcular(venda);

		assertEquals(esperado, comissao, 0);
	}

	@Test
	public void testeCalculoComissaoVenda550() {
		int venda = 550;
		double esperado = 27.5;

		double comissao = CalculadoraComissao.calcular(venda);

		assertEquals(esperado, comissao, 0);
	}
	
	@Test
	public void testeCalculoComissaoVendaSemPrejuizo() {
		double venda = 55.59;
		double esperado = 2.77;

		double comissao = CalculadoraComissao.calcular(venda);

		assertEquals(esperado, comissao, 0);
	}
	
	@Test
	public void teste_comissao_sem_tomar_prejuizo_venda_555555ponto59_retorna_33333ponto33() {
		double venda = 555555.59;
		double esperado = 33333.33;

		double comissao = CalculadoraComissao.calcular(venda);

		assertEquals(esperado, comissao, 0);
	}
}