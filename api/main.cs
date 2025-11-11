using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

public class VercelHandler
{
    public async Task<string> Handler(HttpRequest request)
    {
        var cliente = new Cliente(1, "Cliente Exemplo");
        var enderecoEntrega = new EnderecoEntrega("Rua Exemplo", "Bairro Exemplo", "Cidade Exemplo", "Estado Exemplo", "12345-678");
        var pedido = new Pedido(cliente, enderecoEntrega);

        var produto1 = new Produto("Produto A", 10.50);
        var produto2 = new Produto("Produto B", 25.00);
        var produto3 = new Produto("Produto C", 5.75);

        pedido.AdicionarItem(produto1, 2);
        pedido.AdicionarItem(produto2, 1);
        pedido.AdicionarItem(produto3, 5);

        return await Task.FromResult(pedido.ToString());
    }
}
