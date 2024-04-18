using Newtonsoft.Json.Linq;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        private HashSet<string> mappedRecords = new HashSet<string>();
        private Random rnd = new Random();


        public Form3()
        {
            InitializeComponent();
        }


        private void btnOpenFile1_Click_1(object sender, EventArgs e)
        {
            OpenJsonFileAndLoad1(txtJsonData1);
        }

        private void btnOpenFile2_Click(object sender, EventArgs e)
        {
            OpenJsonFileAndLoad2(txtJsonData2);
            CompareAndHighlightNodes(txtJsonData1.Nodes, txtJsonData2.Nodes, new HashSet<string>());


        }
        private void OpenJsonFileAndLoad1(TreeView treeView)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON Files (.json)|*.json|All Files (.*)|*.*";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;
                    string fileContent = File.ReadAllText(fileName);

                    LoadJsonToTreeView(fileContent, treeView);
                }
            }
        }

        private void OpenJsonFileAndLoad2(TreeView treeView)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON Files (.json)|*.json|All Files (.*)|*.*";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;
                    string fileContent = File.ReadAllText(fileName);

                    LoadJsonToTreeView(fileContent, treeView);
                }
            }
        }


        private void LoadJsonToTreeView(string jsonContent, TreeView treeView)
        {
            if (!string.IsNullOrEmpty(jsonContent))
            {
                JToken jsonToken = JToken.Parse(jsonContent);

                if (treeView == null)
                {
                    treeView = new TreeView();
                    treeView.Location = new System.Drawing.Point(12, 48);
                    treeView.Size = new System.Drawing.Size(400, 400);
                    this.Controls.Add(treeView);
                }
                else
                {
                    treeView.Nodes.Clear();
                }
           


                AddJsonToTreeView(jsonToken, treeView.Nodes);
            }
            else
            {
                MessageBox.Show("Empty JSON content.");
            }
        }


        private void AddJsonToTreeView(JToken token, TreeNodeCollection nodes)
        {
            if (token is JObject)
            {
                JObject obj = (JObject)token;

                foreach (var property in obj.Properties())
                {
                    TreeNode newNode = new TreeNode($"\"{property.Name}\": ");
                    nodes.Add(newNode);
                    AddJsonToTreeView(property.Value, newNode.Nodes);
                }
            }
            else if (token is JArray)
            {
                JArray arr = (JArray)token;

                for (int i = 0; i < arr.Count; i++)
                {
                    TreeNode newNode = new TreeNode($"[{i}]");
                    nodes.Add(newNode);
                    AddJsonToTreeView(arr[i], newNode.Nodes);
                }
            }
            else
            {
                nodes.Add(token.ToString());
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView1_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));

        }

        private void treeView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TreeNode)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void treeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);

        }

        private void treeView2_AfterExpand(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null && e.Node.Parent != null)
            {
                foreach (TreeNode node in e.Node.Parent.Nodes)
                {
                    if (node != e.Node && node.IsExpanded)
                    {
                        node.Collapse();
                    }
                }
            }
        }

        private void treeView2_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));



            if (draggedNode != null)
            {
                TreeNode targetNode = txtJsonData2.GetNodeAt(txtJsonData2.PointToClient(new Point(e.X, e.Y)));
                if (targetNode != null)
                {
                    //Random rnd = new Random();
                    Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

                    draggedNode.BackColor = randomColor;
                    targetNode.BackColor = randomColor;

                    txtJsonData2.SelectedNode = targetNode;

                    string mapping = $"{draggedNode.Text} -> {targetNode.Text}";

                    if (!mappedRecords.Contains(mapping))
                    {
                        mappedRecords.Add(mapping);
                        //listBoxMappedRecords.Items.Add(mapping); // Display mapped records in a ListBox
                    }

                    //MapAndExportToExcel(draggedNode.FullPath, targetNode.FullPath);


                }
            }
        }

        private void treeView2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TreeNode)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void treeView2_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);

        }

        private void treeView1_AfterExpand(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null && e.Node.Parent != null)
            {
                foreach (TreeNode node in e.Node.Parent.Nodes)
                {
                    if (node != e.Node && node.IsExpanded)
                    {
                        node.Collapse();
                    }
                }
            }
        }


        private void MapAndExportToExcel(string item1, string item2)
        {
            string excelFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "MappedItems.xlsx");
            FileInfo excelFile = new FileInfo(excelFilePath);

            using (ExcelPackage package = new ExcelPackage(excelFile))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets["MappingSheet"];

                if (worksheet == null)
                {
                    worksheet = package.Workbook.Worksheets.Add("MappingSheet");
                    worksheet.Cells["A1"].Value = "Box 1 Item";
                    worksheet.Cells["B1"].Value = "Box 2 Item";


                    ExcelRange titleCell = worksheet.Cells["A1:B1"];
                    titleCell.Style.Font.Bold = true;


                    worksheet.Cells["A2"].Value = "";
                }


                int lastUsedRow = worksheet.Dimension?.End.Row ?? 0;


                int startRow = lastUsedRow + 1;


                worksheet.Cells[startRow, 1].Value = item1;
                worksheet.Cells[startRow, 2].Value = item2;


                worksheet.Cells.AutoFitColumns();


                package.Save();
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (mappedRecords.Count > 0)
            {
                // Get the last mapped record from the HashSet
                string lastMapping = mappedRecords.Last();

                // Remove the last mapping from the HashSet
                mappedRecords.Remove(lastMapping);

                // Reset the colors of corresponding TreeView nodes
                string[] parts = lastMapping.Split(new[] { " -> " }, StringSplitOptions.None);
                string node1Text = parts[0];
                string node2Text = parts[1];

                // Find the corresponding nodes in TreeView1 and TreeView2 and reset their colors
                ResetNodeColor(txtJsonData1.Nodes, node1Text);
                ResetNodeColor(txtJsonData2.Nodes, node2Text);
            }
            else
            {
                MessageBox.Show("No mapped records to undo.");
            }
        }

        private void btnSaveMappedTitles_Click(object sender, EventArgs e)
        {
            MapAndExportToExcel();
        }


        private void MapAndExportToExcel()
        {
            string excelFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "MappedItems.xlsx");
            FileInfo excelFile = new FileInfo(excelFilePath);

            using (ExcelPackage package = new ExcelPackage(excelFile))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets["MappingSheet"];

                if (worksheet == null)
                {
                    worksheet = package.Workbook.Worksheets.Add("MappingSheet");
                    worksheet.Cells["A1"].Value = "Box 1 Item";
                    worksheet.Cells["B1"].Value = "Box 2 Item";
                    ExcelRange titleCell = worksheet.Cells["A1:B1"];
                    titleCell.Style.Font.Bold = true;
                    worksheet.Cells["A2"].Value = "";
                }

                int startRow = worksheet.Dimension?.End.Row + 1 ?? 2;

                foreach (string mapping in mappedRecords)
                {
                    string[] parts = mapping.Split(new[] { " -> " }, StringSplitOptions.None);
                    worksheet.Cells[startRow, 1].Value = parts[0];
                    worksheet.Cells[startRow, 2].Value = parts[1];
                    startRow++;
                }

                worksheet.Cells.AutoFitColumns();
                package.Save();
                MessageBox.Show("Mapped records exported to Excel successfully.");
            }
        }



        private void ResetNodeColor(TreeNodeCollection nodes, string nodeText)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Text == nodeText)
                {
                    node.BackColor = Color.White;
                    return;
                }

                if (node.Nodes.Count > 0)
                {
                    ResetNodeColor(node.Nodes, nodeText);
                }
            }
        }

        private void CompareAndHighlightNodes(TreeNodeCollection nodes1, TreeNodeCollection nodes2, HashSet<string> markedValues)
        {
            foreach (TreeNode node1 in nodes1)
            {
                foreach (TreeNode node2 in nodes2)
                {
                    if (!markedValues.Contains(node1.Text) && !markedValues.Contains(node2.Text) && AreNodesEqual(node1, node2))
                    {
                        HighlightMatchingNodes(node1, node2);
                        markedValues.Add(node1.Text);
                        markedValues.Add(node2.Text);
                    }
                }
            }

            // Recursive call for nested nodes
            for (int i = 0; i < nodes1.Count; i++)
            {
                if (i < nodes2.Count && nodes1[i].Nodes.Count > 0 && nodes2[i].Nodes.Count > 0)
                {
                    CompareAndHighlightNodes(nodes1[i].Nodes, nodes2[i].Nodes, markedValues);
                }
            }
        }

        private bool AreNodesEqual(TreeNode node1, TreeNode node2)
        {
            // Check if both nodes are arrays
            //if (node1.Text.StartsWith("[") && node2.Text.StartsWith("["))
            //{
            //    // If both nodes are arrays, compare their array elements
            //    return AreArrayElementsEqual(node1, node2);
            //}
            // Otherwise, compare as usual
            return !IsIndexNode(node1.Text) && !IsIndexNode(node2.Text) && node1.Text == node2.Text && node1.Nodes.Count == node2.Nodes.Count;
        }

        //private bool AreArrayElementsEqual(TreeNode node1, TreeNode node2)
        //{
        //    // Get the array elements as strings
        //    string[] elements1 = GetArrayElements(node1);
        //    string[] elements2 = GetArrayElements(node2);

        //    // Sort and compare the array elements
        //    Array.Sort(elements1);
        //    Array.Sort(elements2);
        //    return elements1.SequenceEqual(elements2);
        //}

        //private string[] GetArrayElements(TreeNode node)
        //{
        //    // Remove brackets and split by comma to get array elements
        //    string text = node.Text.Trim('[', ']');
        //    return text.Split(',');
        //}

        private bool IsIndexNode(string value)
        {
            // Check if the value represents an index node like '[0]', '[1]', etc.
            return Regex.IsMatch(value, @"^\[\d+\]$");
        }

        private void HighlightMatchingNodes(TreeNode node1, TreeNode node2)
        {
            string mapping = $"{node1.Text} -> {node2.Text}";

            if (!mappedRecords.Contains(mapping))
            {
                mappedRecords.Add(mapping);

                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

                node1.BackColor = randomColor;
                node2.BackColor = randomColor;
            }
        }

        private void ClearNodeColors(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                node.BackColor = Color.White; // Reset to default color
                ClearNodeColors(node.Nodes);
            }
        }

        private void AutoMap_Click(object sender, EventArgs e)
        {
            CompareAndHighlightNodes(txtJsonData1.Nodes, txtJsonData2.Nodes, new HashSet<string>());

        }
    }
}
