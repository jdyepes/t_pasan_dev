import { EntidadBase } from "./EntidadBase";
import { Cliente } from "./Cliente";

export class Administrador extends EntidadBase {

    private _nombre: string;
    private _nombreUsuario: string;
    private _correo: string;
    private _password: string;
    private _fechaRegistro: string;
    private _cliente: Cliente;

    constructor(data?: any) {
        super();
        if (data !== undefined) {
            this.$id = data._id;
            this.$nombre = data._nombre;
            this.$nombreUsuario = data._nombreUsuario;
            this.$correo = data._correo;
            this.$password = data._password;
            this.$fechaRegistro = data._fechaRegistro;
            this.$cliente = data._cliente;
        }
    }

    /** Getters y setters */
    public get $nombre(): string {
        return this._nombre;
    }

    public set $nombre(value: string) {
        this._nombre = value;
    }

    public get $nombreUsuario(): string {
       return this._nombreUsuario;
    }

    public set $nombreUsuario(value: string) {
        this._nombreUsuario = value;
    }

    public get $correo(): string {
        return this._correo;
    }

    public set $correo(value: string) {
        this._correo = value;
    }

    public get $password(): string {
        return this._password;
    }

    public set $password(value: string) {
        this._password = value;
    }

    public get $fechaRegistro(): string {
        return this._fechaRegistro;
    }

    public set $fechaRegistro(value: string) {
        this._fechaRegistro = value;
    }
    
    public get $cliente(): Cliente {
        return this._cliente;
    }

    public set $cliente(value: Cliente) {
        this._cliente = value;
    }
}