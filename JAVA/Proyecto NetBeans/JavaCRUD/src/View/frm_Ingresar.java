/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package View;

/**
 *
 * @author meire
 */
public class frm_Ingresar extends javax.swing.JPanel {

    /**
     * Creates new form frm_Ingresar
     */
    public frm_Ingresar() {
        initComponents();
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        buttonGroup1 = new javax.swing.ButtonGroup();
        label1 = new java.awt.Label();
        label2 = new java.awt.Label();
        tf_IngresarPlaca = new javax.swing.JTextField();
        tf_IngresarPropietario = new javax.swing.JTextField();
        ra_Masculino = new javax.swing.JRadioButton();
        ra_Femenino = new javax.swing.JRadioButton();
        btn_Guardar = new javax.swing.JButton();

        label1.setAlignment(java.awt.Label.CENTER);
        label1.setText("Placa");

        label2.setAlignment(java.awt.Label.CENTER);
        label2.setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        label2.setText("Propietario");

        tf_IngresarPlaca.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                tf_IngresarPlacaActionPerformed(evt);
            }
        });

        tf_IngresarPropietario.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                tf_IngresarPropietarioActionPerformed(evt);
            }
        });

        ra_Masculino.setText("Masculino");
        ra_Masculino.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                ra_MasculinoActionPerformed(evt);
            }
        });

        ra_Femenino.setText("Femenino");
        ra_Femenino.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                ra_FemeninoActionPerformed(evt);
            }
        });

        btn_Guardar.setText("Guardar");
        btn_Guardar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_GuardarActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(this);
        this.setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(314, 314, 314)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(label1, javax.swing.GroupLayout.PREFERRED_SIZE, 139, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addGroup(layout.createSequentialGroup()
                                .addGap(28, 28, 28)
                                .addComponent(label2, javax.swing.GroupLayout.PREFERRED_SIZE, 101, javax.swing.GroupLayout.PREFERRED_SIZE))))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(158, 158, 158)
                        .addComponent(btn_Guardar, javax.swing.GroupLayout.PREFERRED_SIZE, 467, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(287, 287, 287)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(ra_Masculino)
                                .addGap(18, 18, 18)
                                .addComponent(ra_Femenino))
                            .addComponent(tf_IngresarPlaca, javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(tf_IngresarPropietario, javax.swing.GroupLayout.Alignment.TRAILING))))
                .addContainerGap(197, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(62, 62, 62)
                .addComponent(label1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(27, 27, 27)
                .addComponent(tf_IngresarPlaca, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(50, 50, 50)
                        .addComponent(label2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(23, 23, 23)
                        .addComponent(tf_IngresarPropietario, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 110, Short.MAX_VALUE))
                    .addGroup(layout.createSequentialGroup()
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(ra_Femenino)
                            .addComponent(ra_Masculino))
                        .addGap(46, 46, 46)))
                .addComponent(btn_Guardar, javax.swing.GroupLayout.PREFERRED_SIZE, 52, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(34, 34, 34))
        );
    }// </editor-fold>//GEN-END:initComponents

    private void btn_GuardarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_GuardarActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_btn_GuardarActionPerformed

    private void tf_IngresarPlacaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_tf_IngresarPlacaActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_tf_IngresarPlacaActionPerformed

    private void tf_IngresarPropietarioActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_tf_IngresarPropietarioActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_tf_IngresarPropietarioActionPerformed

    private void ra_FemeninoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_ra_FemeninoActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_ra_FemeninoActionPerformed

    private void ra_MasculinoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_ra_MasculinoActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_ra_MasculinoActionPerformed


    // Variables declaration - do not modify//GEN-BEGIN:variables
    public javax.swing.JButton btn_Guardar;
    private javax.swing.ButtonGroup buttonGroup1;
    private java.awt.Label label1;
    private java.awt.Label label2;
    public javax.swing.JRadioButton ra_Femenino;
    public javax.swing.JRadioButton ra_Masculino;
    public javax.swing.JTextField tf_IngresarPlaca;
    public javax.swing.JTextField tf_IngresarPropietario;
    // End of variables declaration//GEN-END:variables

    public void setLocationRelativeTo(Object object) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    public void setTitle(String registro_de_vehiculos) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
}
