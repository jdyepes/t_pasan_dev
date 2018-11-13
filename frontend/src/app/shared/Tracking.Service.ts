import { Injectable, Injector } from '@angular/core';
import { Http, Headers } from '@angular/http';
import { RequestOptions, Request } from '@angular/http';
import { Path, AppUrlBase, method } from '../consts/Path.const';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from '../../environments/environment';
import { Entrada } from '../models/Entrada';
import { Salida } from '../models/Salida';
import { Cliente } from '../models/Cliente';
import { Pedido } from '../models/Pedido';
import { Administrador } from '../models/Administrador';


const httpOptions = {
    headers: new HttpHeaders({
        // 'Content-Type':  'text/html',
        'Access-Control-Allow-Origin': '*'
    })
};

@Injectable()
export class TrackingService {

    apiUrlEntrada = AppUrlBase.appUrlBase + Path.ENTRADA;
    apiUrlSalida = AppUrlBase.appUrlBase + Path.SALIDA;
    apiUrlPedido = AppUrlBase.appUrlBase + Path.PEDIDO;
    apiUrlCliente = AppUrlBase.appUrlBase + Path.CLIENTE;
    apiUrlLoginAdmin = AppUrlBase.appUrlBase + Path.ADMINISTRADOR;
    apiUrlLoginCliente = AppUrlBase.appUrlBase + Path.CLIENTE;

    public listaEntrada: Entrada[];
    public listaSalida: Salida[];
    public listaPedido: Pedido[];
    public listaCliente: Cliente[];

    constructor(private http: HttpClient) {
    }

    ObtenerEntradaClientes(idCliente: number): Promise<any> {
        const url = this.apiUrlEntrada + method.ObtenerEntradaCliente + idCliente;

        return this.http.get<Entrada>(url, httpOptions).toPromise()
            .then((res) => {

                console.log(res);
                let entrada: Entrada[] = this.transformarDataToArray(res);
                console.log(entrada);
                this.listaEntrada = entrada;
                return this.listaEntrada;

            },
                (error) => {
                    console.log(error);
                    return null;
                }
            );
    }

    ObtenerSalidaClientes(idCliente: number): Promise<any> {
        const url = this.apiUrlSalida + method.ObtenerSalidaCliente + idCliente;

        return this.http.get<Salida>(url, httpOptions).toPromise()
            .then((res) => {

                console.log(res);
                let salida: Salida[] = this.transformarDataToArraySalida(res);
                console.log(salida);
                this.listaSalida = salida;
                return this.listaSalida;

            },
                (error) => {
                    console.log(error);
                    return null;
                }
            );
    }


    ObtenerPedidoClientes(idCliente: number): Promise<any> {
        const url = this.apiUrlPedido + method.ObtenerPedidoCliente + idCliente;

        return this.http.get<Pedido>(url, httpOptions).toPromise()
            .then((res) => {

                console.log(res);
                let pedido: Pedido[] = this.transformarDataToArrayPedido(res);
                console.log(pedido);
                this.listaPedido = pedido;

                return this.listaPedido;

            },
                (error) => {
                    console.log(error);
                    return null;
                }
            );
    }

    ObtenerClienteAdmin(idAdmin: number): Promise<any> {
        const url = this.apiUrlCliente + method.ObtenerClienteAdministrador + idAdmin;

        return this.http.get<Cliente>(url, httpOptions).toPromise()
            .then((res) => {

                console.log(res);
                let cliente: Cliente[] = this.transformarDataToArrayCliente(res);
                console.log(cliente);
                this.listaCliente = cliente;

                return this.listaCliente;

            },
                (error) => {
                    console.log(error);
                    return null;
                }
            );
    }

    LoginAdmin(userName: string): Promise<any> {
        const url = this.apiUrlLoginAdmin + method.verificarLoginAdmin + userName;

        return this.http.get<Administrador>(url, httpOptions).toPromise()
            .then((res) => {

                console.log(res);
                let admin: Administrador = res;
                console.log(admin);
                return res;

            },
                (error) => {
                    console.log(error);
                    return null;
                }
            );
    }

    LoginCliente(userName: string): Promise<any> {
        const url = this.apiUrlLoginCliente + method.verificarLoginCliente + userName;

        return this.http.get<Cliente>(url, httpOptions).toPromise()
            .then((res) => {

                console.log(res);
                let cliente: Cliente = res;
                console.log(cliente);
                return res;

            },
                (error) => {
                    console.log(error);
                    return null;
                }
            );
    }

    transformarDataToArray(data) {
        let list: Entrada[] = [];
        data.forEach((object => {
            let entrada = new Entrada(object);
            list.push(entrada);
        }));
        return list;
    }

    transformarDataToArraySalida(data) {
        let list: Salida[] = [];
        data.forEach((object => {
            let salida = new Salida(object);
            list.push(salida);
        }));
        return list;
    }

    transformarDataToArrayPedido(data) {
        let list: Pedido[] = [];
        data.forEach((object => {
            let pedido = new Pedido(object);
            list.push(pedido);
        }));
        return list;
    }

    transformarDataToArrayCliente(data) {
        let list: Cliente[] = [];
        data.forEach((object => {
            let cliente = new Cliente(object);
            list.push(cliente);
        }));
        return list;
    }
}