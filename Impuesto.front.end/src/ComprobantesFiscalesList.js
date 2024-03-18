import React, { useState, useEffect } from 'react';
import axios from 'axios';

function ComprobantesFiscalesList() {
  const [comprobantes, setComprobantes] = useState([]);

  useEffect(() => {
    fetchComprobantes();
  }, []);

  const fetchComprobantes = async () => {
    try {
      const response = await axios.get('https://localhost:7217/api/ComprobantesFiscales');
      setComprobantes(response.data);
    } catch (error) {
      console.error('Error al obtener los comprobantes fiscales:', error);
    }
  };

  return (
    <div>
      <h1>Listado de Comprobantes Fiscales</h1>
      <table>
        <thead>
          <tr>
            <th>NCF</th>
            <th>Monto</th>
            <th>ITBIS 18%</th>
          </tr>
        </thead>
        <tbody>
          {comprobantes.map((comprobante) => (
            <tr key={comprobante.id}>
              <td>{comprobante.ncf}</td>
              <td>{comprobante.monto}</td>
              <td>{comprobante.itbis18}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default ComprobantesFiscalesList;
